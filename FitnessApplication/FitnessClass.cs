using System;
using System.Collections.Generic;

namespace FitnessApplication
{
    public class FitnessClass
    {
        public int ClassID { get; set; }
        public string ClassName { get; set; }
        public string Instructor { get; set; }
        public DateTime Schedule { get; set; }
        public int Capacity { get; set; }
        public List<string> Participants { get; set; } = new List<string>();

        public void AddReview(string username, int rating, string review)
        {
            // Store reviews for database in Phase 2
        }
    }
}
