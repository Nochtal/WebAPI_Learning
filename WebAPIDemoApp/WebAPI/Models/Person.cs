namespace WebAPI.Models
{
    /// <summary>
    /// Represents one specific person
    /// </summary>
    public class Person
    {
        /// <summary>
        /// ID from SQL
        /// </summary>
        public int Id { get; set; } = 0;
        /// <summary>
        /// Users first name.
        /// </summary>
        public string FName { get; set; } = "";
        /// <summary>
        /// Users last name.
        /// </summary>
        public string LName { get; set; } = "";
    }
}