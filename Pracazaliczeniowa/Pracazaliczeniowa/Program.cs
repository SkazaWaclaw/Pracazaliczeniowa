
using Pracazaliczeniowa;

User user1 = new User("Wacław","324423fddf");
User user2 = new User("Monika","324423fddf");
User user3 = new User("Zuzia","324423fddf");
User user4 = new User("Franek","324423fddf");

user1.AddScore(5);
user1.AddScore(2);
var result = user1.Result;
Console.WriteLine(result);





