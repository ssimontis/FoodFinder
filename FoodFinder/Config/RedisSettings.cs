namespace FoodFinder.Config; 

public class RedisSettings {
  public const string Prefix = "Redis";

  public string User { get; set; }

  public string Password { get; set; }

  public string ConnectionUrl { get; set; }
}
