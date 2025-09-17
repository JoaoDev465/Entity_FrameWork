namespace Entity;

public class UserModel
{
    // we have a Db Table user.
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public short Old { get; set; }
}