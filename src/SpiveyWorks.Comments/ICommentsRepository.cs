using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpiveyWorks.Comments
{
    public interface ICommentsRepository
    {
        void Create(Comment comment);
        Comment[] GetByTargetId(string targetId);
        void Update(Comment comment);
        void Delete(string commentId);
    }
}
