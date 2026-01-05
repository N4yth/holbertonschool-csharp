enum Rating
{
    Good,
    Great,
    Excellent
}

struct Dog
{
    public string name;
    public float age;
    public string owner;
    public Rating rating;

    public Dog(string dog_name, float dog_age, string dog_owner, Rating dog_rating)
    {
        name = dog_name;
        age = dog_age;
        owner = dog_owner;
        rating = dog_rating;
    }
    public override string ToString()
    {
        return $"Dog Name: {name}\nAge: {age}\nOwner: {owner}\nRating: {rating}";
    }
}