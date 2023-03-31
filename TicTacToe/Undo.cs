using System;
using TicTacToe;

public class Undo
{
    internal Stack<Field> undo;
    

    public Undo()
    {
        //grid = new Grid(size);
        undo = new Stack<Field>();
    }

    public void Push(Field field)
    {
        //Field[,] arr = grid;
        undo.Push(field);
        
    }

    public void Pop()
    {
        undo.Pop();
        
    }
}

