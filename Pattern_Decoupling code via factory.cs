// The factory pattern is a design pattern that provides an interface for creating objects in a super class, but allows subclasses to alter the type of objects that will be created. It is useful when you want to create objects that are part of a larger family of related objects, but you don't want the client code to have to be aware of the specific types of objects that are being created.

public interface IPuzzlePiece
{
    void Interact();
}

public class PuzzlePieceA : IPuzzlePiece
{
    public void Interact()
    {
        // Puzzle piece A interaction logic
    }
}

public class PuzzlePieceB : IPuzzlePiece
{
    public void Interact()
    {
        // Puzzle piece B interaction logic
    }
}

public class PuzzlePieceC : IPuzzlePiece
{
    public void Interact()
    {
        // Puzzle piece C interaction logic
    }
}

public class PuzzlePieceFactory
{
   
    public static IPuzzlePiece CreatePuzzlePiece(string type)
    {
        switch (type)
        {
            case "A":
                return new PuzzlePieceA();
            case "B":
                return new PuzzlePieceB();
            case "C":
                return new PuzzlePieceC();
            default:
                throw new ArgumentException("Invalid puzzle piece type");
        }
    }
}

//*** it decouples the client code from the concrete implementations of the objects being created.
IPuzzlePiece puzzlePieceA = PuzzlePieceFactory.CreatePuzzlePiece("A");
IPuzzlePiece puzzlePieceB = PuzzlePieceFactory.CreatePuzzlePiece("B");
IPuzzlePiece puzzlePieceC = PuzzlePieceFactory.CreatePuzzlePiece("C");

