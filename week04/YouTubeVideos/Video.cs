public class Video
{
  public string _title;
  public string _author;
  public string _length;
  public List<Comment> _comment = new List<Comment>();

  public int NumberOfComments()
  {
    int number = _comment.Count();
    return number;

  }


 }

