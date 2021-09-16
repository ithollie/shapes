namespace buttons
{public class Circle
{
	public string object_name;
	public string object_date;
	public string object_picture;


	public Circle(string object_name, string object_date,  string  object_pic)

	{
		this.object_name = object_name;
		this.object_date = object_date;
		this.object_picture = object_pic;

	}
	public string showShap()
    {
		return object_name;
    }

	public string name()
    {
		return object_name;
    }

	public string DateTime()
    {
		return object_date;
    }

	public void changePicture(string pic)
    {
		object_picture = pic;
    }
}

}