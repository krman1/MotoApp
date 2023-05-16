var stack = new Stack<double>();
stack.Push(30);
stack.Push(45);
stack.Push(26);
stack.Push(32);

double sum = 0;
while(stack.Count > 0)
{
    Console.WriteLine(stack.Peek());

    sum += stack.Pop();
}

Console.WriteLine("Suma wyrazów: " + sum);