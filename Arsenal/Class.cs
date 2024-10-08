using System.Text.Json.Serialization;

public class vapen
{
  [JsonInclude]
  public string Name;

  public int Attack()
  {
    return Random.Shared.Next(5, 15);
  }
}