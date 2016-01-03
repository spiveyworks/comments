using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpiveyWorks.Comments
{
    public class Comment
    {
        string CommentId { get; set; }
        string TargetId { get; set; }
        string UserId { get; set; }
        string UserName { get; set; }
        DateTime CreateTime { get; set; }
        string CommentText { get; set; }
    }
}
