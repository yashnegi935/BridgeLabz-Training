using GenericProject;

User<int>user=new User<int>();
user.id=10123;
user.email="yashnegi@gmail.com";
user.Name = "Yash";

User<string> user2 = new User<string>();

user2.id = "102";
user2.Name = "Rahul";
user2.email = "rahul@gmail.com";

Check.display(user2);
Check.display(user);