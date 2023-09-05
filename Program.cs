using static System.Console;

FavouriteFoodArrayManipulator manipulator = new FavouriteFoodArrayManipulator();
WriteLine("Primo esercizio pomeridiano");
WriteLine();

string[] italianFood = 
            {
                "Risotto",
                "Pizza",
                "Pasta alla carbonara",
                "Polenta e Baccalà",
                "Tiramisu",
                "Gelato",
                "Sarde in Saor",
                "Bigoli all'anitra",
                "Bruschetta",
                "Minestrone"
            };

manipulator.PrintArrayLength(italianFood);

manipulator.PrintArrayRanking(italianFood);

manipulator.PrintFirstItem(italianFood);

manipulator.PrintLastItem(italianFood);

manipulator.PrintMediumItem(italianFood);

ReadKey();

public class FavouriteFoodArrayManipulator{

    public void PrintArrayLength(string[] array){
        WriteLine($"La lunghezza dell'array è {array.Length}"); 
        WriteLine();

    }

    public void PrintArrayRanking(string[] array){
        int index = 1;
        WriteLine("La mia classifica è:");
        foreach (string item in array){
            WriteLine($"{index} - {item}");
            index++;
        }
        WriteLine();
    
    }

    public void PrintFirstItem(string[] array){
        WriteLine($"Il mio cibo preferito è: {array[0]}"); 
        WriteLine();

    }

    public void PrintLastItem(string[] array){
        WriteLine($"All'ultimo posto della mia classifica c'è: {array[array.Length - 1]}");    
        WriteLine();    
    }

    public void PrintMediumItem(string[] array){
        int arrayLength = array.Length;
        int mediumIndex = arrayLength / 2;

        if(arrayLength % 2 == 0){
            WriteLine($"Il cibi nel mezzo sono: {array[mediumIndex -1]} e {array[mediumIndex]}");
        }else{
            WriteLine($"Il cibo nel mezzo é: {array[mediumIndex]}");      

        }
    }
    
}

