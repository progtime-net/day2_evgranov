namespace CalcJun.Interfaces
{
    interface IOperation
    {
        string Name { get; }
        float Execute(float a, float b);
    }
}