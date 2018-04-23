using System;
namespace ExerciseList
{
    public class Search
	{
		public int Id { get; set; }
		public string Location { get; set; }
		public DateTime CheckIn { get; set; }
		public DateTime CheckOut { get; set; }
        public string CheckString{
            get
            {
                return CheckIn.ToString("MMM dd, yyyy") + " - " + CheckOut.ToString("MMM dd, yyyy");
            }
        }
		//public string Period
		//{
		//	get
		//	{
		//		return String.Format("{0} - {1}",
		//				 CheckIn.ToString("MMM d, yyyy"),
		//				 CheckOut.ToString("MMM d, yyyy"));
		//	}
		//}
    }
}
