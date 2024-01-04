string permission = "Admin|Manager";
int level = 65;
string adminTitle = (permission.Contains("Admin") && level > 55) ? "Super Admin" : "Admin";
string adminGreeting = $"Welcome, {adminTitle} user";
string managerGreeting = "Contact an Admin for access";
string accessDenied = "You do not have sufficient privileges";

if (permission.Contains("Admin"))
{
    Console.WriteLine(adminGreeting);
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine(managerGreeting);
    }
    else
    {
        Console.WriteLine(accessDenied);
    }
}
else
{
    Console.WriteLine(accessDenied);
}

