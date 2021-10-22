using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlazorProject
{
    public class KanbanDataModel
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Status { get; set; }
        public string Summary { get; set; }
       
        public string Priority { get; set; }
       
        public string Assignee { get; set; }
       

        public List<KanbanDataModel> GetTasks()
        {
            List<KanbanDataModel> TaskDetails = new List<KanbanDataModel>();
            TaskDetails.Add(new KanbanDataModel { Id = "Task 1", Status = "Open", Summary = "Analyze the new requirements gathered from the customer.", Assignee = "Nancy Davloio", Priority = "Low" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 2", Status = "InProgress", Summary = "Improve application performance", Assignee = "Andrew Fuller", Priority = "Low" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 3", Status = "Open", Summary = "Arrange a web meeting with the customer to get new requirements.", Assignee = "Janet Leverling", Priority = "Low" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 4", Status = "InProgress", Summary = "Fix the issues reported in the IE browser.", Assignee = "Janet Leverling", Priority = "Low" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 5", Status = "Review", Summary = "Fix the issues reported by the customer.", Assignee = "Steven walker", Priority = "Low" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 6", Status = "Review", Summary = "Fix the issues reported in Safari browser.", Assignee = "Nancy Davloio", Priority = "Low" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 7", Status = "Close", Summary = "Test the application in the IE browser.", Assignee = "Margaret hamilt", Priority = "Low" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 8", Status = "Validate", Summary = "Validate the issues reported by the customer.", Assignee = "Steven walker", Priority = "Low" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 9", Status = "Open", Summary = "Show the retrieved data from the server in grid control.", Assignee = "Margaret hamilt", Priority = "Low" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 10", Status = "InProgress", Summary = "Fix cannot open user’s default database SQL error.", Assignee = "Janet Leverling", Priority = "Low" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 11", Status = "Review", Summary = "Fix the issues reported in data binding.", Assignee = "Janet Leverling", Priority = "Low" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 12", Status = "Close", Summary = "Analyze SQL server 2008 connection.", Assignee = "Andrew Fuller", Priority = "Low" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 13", Status = "Validate", Summary = "Validate databinding issues.", Assignee = "Margaret hamilt", Priority = "Low" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 14", Status = "Close", Summary = "Analyze grid control.", Assignee = "Margaret hamilt", Priority = "Low"  });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 15", Status = "Close", Summary = "Stored procedure for initial data binding of the grid.", Assignee = "Steven walker", Priority = "Low" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 16", Status = "Close", Summary = "Analyze stored procedures.", Assignee = "Janet Leverling", Priority = "Low" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 17", Status = "Validate", Summary = "Validate editing issues.", Assignee = "Nancy Davloio", Priority = "Low" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 18", Status = "Review", Summary = "Test editing functionality.", Assignee = "Nancy Davloio", Priority = "Low" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 19", Status = "Open", Summary = "Enhance editing functionality.", Assignee = "Andrew Fuller", Priority = "Low" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 20", Status = "InProgress", Summary = "Improve the performance of the editing functionality.", Assignee = "Nancy Davloio", Priority = "Low" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 21", Status = "Open", Summary = "Arrange web meeting with the customer to show editing demo.", Assignee = "Steven walker", Priority = "Low" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 22", Status = "Review", Summary = "Fix the editing issues reported by the customer.", Assignee = "Janet Leverling", Priority = "Low" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 23", Status = "Testing", Summary = "Fix the issues reported by the customer.", Assignee = "Steven walker", Priority = "Low" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 24", Status = "Testing", Summary = "Fix the issues reported in Safari browser.", Assignee = "Nancy Davloio", Priority = "Low" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 25", Status = "Testing", Summary = "Fix the issues reported in data binding.", Assignee = "Janet Leverling", Priority = "Low" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 26", Status = "Testing", Summary = "Test editing functionality.", Assignee = "Nancy Davloio", Priority = "Low" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 27", Status = "Testing", Summary = "Test editing feature in the IE browser.", Assignee = "Janet Leverling", Priority = "Low" });
            return TaskDetails;
        }

        public List<KanbanDataModel> GetTaskProgress()
        {
            List<KanbanDataModel> ProgressDetails = new List<KanbanDataModel>();
            ProgressDetails.Add(
                new KanbanDataModel { 
                    Id = "0", 
                    Status = "Open", 
                    Assignee = "Nancy Davloio", 
                    Priority = "Low" 
                });
            ProgressDetails.Add(
                new KanbanDataModel { 
                    Id = "1",
                    Status = "InProgress",
                    Assignee = "Andrew Fuller",
                    Priority = "Normal" 
                });
            ProgressDetails.Add(
                new KanbanDataModel { 
                    Id = "2", 
                    Status = "Testing", 
                    Assignee = "Janet Leverling", 
                    Priority = "Critical" 
                });
            ProgressDetails.Add(
                new KanbanDataModel { 
                    Id = "3", 
                    Status = "Close", 
                    Assignee = "Steven walker", 
                    Priority = "Release Breaker" });
            return ProgressDetails;
        }
    }
}
