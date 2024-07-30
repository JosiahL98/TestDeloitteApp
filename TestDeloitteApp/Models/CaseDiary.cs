namespace TestDeloitteApp.Models
{
    public class CaseDiary
    {
        public int Id { get; set; }
        public string  CaseId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }
        public string Function { get; set; }
        public string SubFunction { get; set; }
        public string Open { get; set; }
        public string Prim { get; set; }
        public string Mother { get; set; }
        public string Father { get; set; }
        public bool MotherViolence { get; set; }
        public bool FatherViolence { get; set; }
    }
}
