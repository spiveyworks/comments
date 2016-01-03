using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpiveyWorks.Comments.Sql
{
    public class SqlCommentsRepository : ICommentsRepository
    {
        public static string ConnectionStringSettingName = "ConnectionString";

        public string ConnectionString { get; set; }

        public SqlCommentsRepository(Dictionary<string, object> settings)
        {
            if (settings[ConnectionStringSettingName] != null)
                this.ConnectionString = (string)settings[ConnectionStringSettingName];
        }

        public void Create(Comment comment)
        {
            throw new NotImplementedException();
        }

        public void Delete(string commentId)
        {
            throw new NotImplementedException();
        }

        public Comment[] GetByTargetId(string targetId)
        {
            throw new NotImplementedException();
        }

        public void Update(Comment comment)
        {
            throw new NotImplementedException();
        }
    }
}
