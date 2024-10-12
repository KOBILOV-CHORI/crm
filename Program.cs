using CRM.DataContext;
using CRM.Entities;
DataContext context = new DataContext();

//Task 1
// var projects = from p in context.Projects
//         join t in context.Tasks on p.ProjectId equals t.ProjectId
//         join u in context.Users on p.ManagerId equals u.UserId

//         select t;

//Task 4
// var tasks = from t in context.Tasks
//         where (DateTimeOffset.UtcNow.DayOfYear - t.CreatedAt.DayOfYear) > 30
//         select t;
// foreach (var task in tasks)
// {
//     System.Console.WriteLine(task.TaskName + " " + task.TaskId);
// }

//Task 7
// var comments = from c in context.Comments
//         join t in context.Tasks on c.TaskId equals t.TaskId
//         where t.Status == CRM.Enums.TaskStatus.InProgress
//         orderby c.CreatedAt
//         select c;
// foreach (var comment in comments)
// {
//     System.Console.WriteLine(comment.Text);
// }

//Task 5
// var projects = from p in context.Projects
//         join t in context.Tasks on p.ProjectId equals t.ProjectId
//         where t.Status == CRM.Enums.TaskStatus.Completed
//         select p;
// foreach (var project in projects)
// {
//     System.Console.WriteLine(project.ProjectName);
// }

//Task 6
// var users1 = context.Users.Select(u => u);
// var users = users1.Where(u => u.ManagedProjects == null && u.AssignedTasks == null);
// foreach (var user in users)
// {
//     System.Console.WriteLine(user.FirstName);
// }
