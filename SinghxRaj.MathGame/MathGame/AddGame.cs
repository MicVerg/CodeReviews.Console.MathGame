﻿namespace SinghxRaj.MathGame.MathGame;

internal class AddGame : MathGame
{

    public override double Compute(int operand1, int operand2)
    {
        return operand1 + operand2;
    }

    public override string GetOperator()
    {
        return "+";
    }
}
