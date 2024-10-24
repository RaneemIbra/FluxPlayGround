namespace MauiApp1.Models;

public class GroupChatModel
{
    public int GroupId { get; set; }
    public string GroupName { get; set; }
    public List<UserModel> GroupMemebers { get; set; }
}