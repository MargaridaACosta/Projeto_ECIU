public class User 
{
    public bool login = true;
    public string username;
    public string userid;
    public string email;
    public string birthDate;
    public string gender;
    public string photo;
    public int[] badges;
    public int[] photos;
    public int[] videos;
    public float[] location;



    public User(string userid = null, string username = null, string email = null, string birthDate = null, string gender = null, string photo = null, int[] badges = null, int[] photos = null, int[] videos = null, float[] location = null)
    {

        this.userid = userid;
        this.username = username;
        this.email = email;
        this.birthDate = birthDate;
        this.gender = gender;
        this.photo = photo;
        this.badges = badges;
        this.photos = photos;
        this.videos = videos;
        this.location = location;



    }

}
