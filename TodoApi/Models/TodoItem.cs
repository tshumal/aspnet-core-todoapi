using System;
using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models
{     
    public class TodoItem
    { 
        public Guid Id { get; set; }        
        public string Name { get; set; }         
        public bool IsComplete { get; set; }   
        [Required]
        public string Title { get; set; }
        public DateTimeOffset? DueAt { get; set; }
    }

}