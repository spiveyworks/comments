# comments
A .NET Core repository reference with implementations developers that want a Comments back-end capability for their website or app.

Projects:

SpiveyWorks.Comments.CommentsRef
The reference SpiveyWorks.CommentsRef project is to use the .NET Core library so it can be compiled to run on Windows, Mac and Linux. This reference project will contain a ICommentsRepository interface and a Comment class. This is what 3rd party code should reference in their projects.

SpiveyWorks.Comments.Azure
This SpiveyWorks.Comments.Azure project references the SpiveyWorks.Comments.CommentsRef project and is a Azure-specific implementation of the repository. This implementation uses the Windows Azure SDK to persist all data in Azure Table Storage and Azure Blob Storage.

SpiveyWorks.Comments.Sql
This SpiveyWorks.Comments.Sql project references the SpiveyWorks.Comments.CommentsRef project is a SQL Server-specific implementation of the repository. This implememtation uses Entity Framework to persist all data in SQL Server.

Comment Data Structure:
string CommentId
string TargetId
string UserId
DateTime CreateTime
string CommentText

Primary use cases:
1. Create a comment associated with a user and a target ID (like a blog post URL or primary key)
2. Get comments associated with a given target ID and order in ascending order by CreateTime.
3. Update a comment associated with a user and a target ID.
4. Delete a comment by CommentId.
