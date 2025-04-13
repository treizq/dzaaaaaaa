using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using aa;
using static aa.State;

public class Program
{
    static void Main(string[] args)
    {
        Cat cat1 = new Cat { Name = "мурзик", Breed = "сиамский", Weight = 2.5 };
        Cat cat2 = new Cat { Name = "барсик", Breed = "персидский", Weight = 4.0 };
        Console.WriteLine(cat1 < cat2);
        Console.WriteLine(cat1 * cat2);

        Console.WriteLine(CatWeightChecker.CheckWeight(cat1)); //котик худой
        Console.WriteLine(CatWeightChecker.CheckWeight(cat2)); //котик полноват
        Console.WriteLine($"\n");

        Person person1 = new Person { FullName = "Иванов Иван Иванович", Gender = "мужик", Age = 30, EyeColor = "карие" };
        Person person2 = new Person { FullName = "Петрова Анна Сергеевна", Gender = "вумен", Age = 28, EyeColor = "голубые" };

        //цвет глаз детей
        string childEyeColor = person1 + person2;
        Console.WriteLine($"цвет глаз детей: {childEyeColor}");
        Console.WriteLine(WorkAbility.IsEligible(person1));
        Console.WriteLine(WorkAbility.IsEligible(person2));
        Console.WriteLine($"\n");



        Game gamee = new Game
        {
            Name = "Super Game",
            AveragePlayers = 1200,
            MaxPlayers = 15000,
            Rating = 8.0
        };

        gamee++;
        Console.WriteLine($"рейтинг после увеличения: {gamee.Rating}");


        gamee--;
        Console.WriteLine($"рейтинг после уменьшения: {gamee.Rating}");


        bool isPopular = PopularGame.IsPopular(gamee);
        Console.WriteLine($"игра популярна: {isPopular}");
        Console.WriteLine($"\n");

        //8
        State state1 = new State
        {
            Name = "государство A",
            Population = 500000,
            Area = 1000000
        };

        State state2 = new State
        {
            Name = "государство B",
            Population = 200000,
            Area = 800000
        };

        State combinedState = state1 + state2;
        Console.WriteLine($"объединенное государство: {combinedState.Name}, население: {combinedState.Population}, площадь: {combinedState.Area}");

        if (state1 > state2)
        {
            Console.WriteLine($"{state1.Name} больше, чем {state2.Name}");
        }
        else if (state1 < state2)
        {
            Console.WriteLine($"{state2.Name} больше, чем {state1.Name}");
        }
        else
        {
            Console.WriteLine($"{state1.Name} и {state2.Name} равны");
        }

        string result1 = Empire.IsEmpire(state1);
        string result2 = Empire.IsEmpire(state2);

        Console.WriteLine($"{state1.Name}: {result1}");
        Console.WriteLine($"{state2.Name}: {result2}");
        Console.WriteLine($"\n");



        //99999999999999999999999999
        Ingredient ingredient1 = new Ingredient
        {
            Name = "корень мандрагоры",
            Effect = "усиление магии",
            Price = 80
        };

        Ingredient ingredient2 = new Ingredient
        {
            Name = "крыло летучей мыши",
            Effect = "лечение",
            Price = 200
        };

        Ingredient potion = ingredient1 + ingredient2;
        Console.WriteLine($"зелье: {potion.Name}, эффект: {potion.Effect}, цена: {potion.Price}");

        if (ingredient1 > ingredient2)
        {
            Console.WriteLine($"{ingredient1.Name} дороже, чем {ingredient2.Name}");
        }
        else if (ingredient1 < ingredient2)
        {
            Console.WriteLine($"{ingredient2.Name} дороже, чем {ingredient1.Name}");
        }
        else
        {
            Console.WriteLine($"{ingredient1.Name} и {ingredient2.Name} стоят одинаково");
        }

        string result11 = PriceChecker.CheckPrice(ingredient1);
        string result22 = PriceChecker.CheckPrice(ingredient2);
        string result3 = PriceChecker.CheckPrice(potion);

        Console.WriteLine($"{ingredient1.Name}: {result1}");
        Console.WriteLine($"{ingredient2.Name}: {result2}"); 
        Console.WriteLine($"{potion.Name}: {result3}"); 
        Console.WriteLine($"\n");

        /////1000000000
        SocialMediaPost post = new SocialMediaPost
        {
            Id = 1,
            Likes = 10,
            Dislikes = 3,
            Message = "салам!"
        };

        Console.WriteLine($"исходный пост: лайки = {post.Likes}, дизлайки = {post.Dislikes}");

        post = post + 5;
        Console.WriteLine($"после добавления 5 лайков: лайки = {post.Likes}, дизлайки = {post.Dislikes}");

        post = post - 2;
        Console.WriteLine($"после добавления 2 дизлайков: лайки = {post.Likes}, дизлайки = {post.Dislikes}");

        post++;
        Console.WriteLine($"после увеличения лайков на 1: лайки = {post.Likes}, дизлайки = {post.Dislikes}");

        post--;
        Console.WriteLine($"после увеличения дизлайков на 1: лайки = {post.Likes}, дизлайки = {post.Dislikes}");

        bool isRecommended = Recommendations.IsRecommended(post);
        Console.WriteLine($"рекомендовать пост? {isRecommended}");
    }

}


