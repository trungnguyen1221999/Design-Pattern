

namespace Prototype_Design_Pattern
{
    public class ServerConfiguration : IPrototype
    {
        public string FileStorageUrl { get; set; } = string.Empty;
        public string OperationSystem { get; set; } = string.Empty;

        private string _dbConnection { get; set; } = string.Empty;
        public object Clone()
        {
            var clone = new ServerConfiguration()
            {
                FileStorageUrl = this.FileStorageUrl,
                OperationSystem = this.OperationSystem,
                _dbConnection = "This is private connection"
            };
            return clone;
        }
        public string GetDetail()
        {
            return $"Storage Url : {this.FileStorageUrl} - Operation System : {this.OperationSystem}  - Database Connection: {this._dbConnection}";
        }
    }
}
