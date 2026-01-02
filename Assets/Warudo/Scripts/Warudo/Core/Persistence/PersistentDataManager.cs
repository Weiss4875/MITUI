using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Cysharp.Threading.Tasks;
using Newtonsoft.Json;
using Application = UnityEngine.Device.Application;

namespace Warudo.Core.Persistence {
    public class PersistentDataManager {

        private readonly string basePath;
        
        public PersistentDataManager() {
            basePath = Application.streamingAssetsPath + "/";
        }

        public IEnumerable<FileEntry> GetFileEntries(string relativePath, string searchPattern = "*.*", Func<string, bool> predicate = null) {
            var e = Directory.EnumerateFiles(basePath + relativePath + Path.DirectorySeparatorChar, searchPattern, SearchOption.AllDirectories);
            if (predicate != null) e = e.Where(predicate);
            return e.Select(it => new FileEntry {
                path = Path.GetRelativePath(basePath, it).Replace('\\', '/'),
                relativePath = Path.GetRelativePath(basePath + relativePath, it).Replace('\\', '/'),
                absolutePath = basePath + Path.GetRelativePath(basePath, it).Replace('\\', '/'),
                fileName = Path.GetFileName(it),
                lastModifiedTime = new DateTimeOffset(File.GetLastWriteTimeUtc(it)).ToUnixTimeMilliseconds()
            });
        }

        public async UniTask WriteFileAsync(string relativePath, string contents) {
            Directory.CreateDirectory(Path.GetDirectoryName(basePath + relativePath)!);
            await File.WriteAllTextAsync(basePath + relativePath, contents);
        }
        
        public async UniTask WriteFileBytesAsync(string relativePath, byte[] bytes) {
            Directory.CreateDirectory(Path.GetDirectoryName(basePath + relativePath)!);
            await File.WriteAllBytesAsync(basePath + relativePath, bytes);
        }
        
        public void WriteFile(string relativePath, string contents) {
            Directory.CreateDirectory(Path.GetDirectoryName(basePath + relativePath)!);
            File.WriteAllText(basePath + relativePath, contents);
        }
        
        public void WriteFileBytes(string relativePath, byte[] bytes) {
            Directory.CreateDirectory(Path.GetDirectoryName(basePath + relativePath)!);
            File.WriteAllBytes(basePath + relativePath, bytes);
        }
        
        public bool HasFile(string relativePath) {
            return File.Exists(basePath + relativePath);
        }
        
        public string GetBasePath() {
            return basePath;
        }
        
        public string GetFullPath(string relativePath) {
            return basePath + relativePath;
        }
        
        public async UniTask<string> ReadFileAsync(string relativePath = "") {
            return await File.ReadAllTextAsync(basePath + relativePath);
        }
        
        public async UniTask<byte[]> ReadFileBytesAsync(string relativePath = "") {
            return await File.ReadAllBytesAsync(basePath + relativePath);
        }
        
        public string ReadFile(string relativePath = "") {
            return File.ReadAllText(basePath + relativePath);
        }
        
        public byte[] ReadFileBytes(string relativePath = "") {
            return File.ReadAllBytes(basePath + relativePath);
        }
        
        public async UniTask<T> ReadFileAsync<T>(string relativePath = "") {
            if (!HasFile(relativePath)) throw new Exception($"File {relativePath} does not exist");
            return JsonConvert.DeserializeObject<T>(await File.ReadAllTextAsync(basePath + relativePath));
        }
        
        public T ReadFile<T>(string relativePath = "") {
            if (!HasFile(relativePath)) throw new Exception($"File {relativePath} does not exist");
            return JsonConvert.DeserializeObject<T>(File.ReadAllText(basePath + relativePath));
        }
        
        public void DeleteFile(string relativePath) {
            File.Delete(basePath + relativePath);
        }
        
    }
}
