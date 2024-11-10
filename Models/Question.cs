using System.Collections.Generic;

namespace DynamicQuestionApp.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }

        // Store Options as a JSON string in the database
        public string OptionsJson { get; set; }

        public List<string> Options
        {
            get => OptionsJson == null ? new List<string>() : System.Text.Json.JsonSerializer.Deserialize<List<string>>(OptionsJson);
            set => OptionsJson = System.Text.Json.JsonSerializer.Serialize(value);
        }

        public string Answer { get; set; } // Correct answer
    }
}
