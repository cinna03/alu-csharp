using System;

// Define the Rating enum
enum Rating
{
    Good,      // 0
    Great,     // 1
    Excellent  // 2
}

// Define the Dog struct
struct Dog
{
    public string name;
    public float age;
    public string owner;
    public Rating rating;

    // Constructor
    public Dog(string name, float age, string owner, Rating rating)
    {
        this.name = name;
        this.age = age;
        this.owner = owner;
        this.rating = rating;
    }
}

