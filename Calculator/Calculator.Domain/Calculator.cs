namespace Calculator.Domain;

/// <summary>
/// Proporciona operaciones aritméticas básicas.
/// </summary>
public class Calculator
{
    /// <summary>
    /// Suma dos números enteros.
    /// </summary>
    /// <param name="x">Primer número.</param>
    /// <param name="y">Segundo número.</param>
    /// <returns>La suma de los dos números.</returns>
    public int Add(int x, int y) => x + y;

    /// <summary>
    /// Resta el segundo número del primero.
    /// </summary>
    /// <param name="x">Minuendo.</param>
    /// <param name="y">Sustraendo.</param>
    /// <returns>La diferencia entre x e y.</returns>
    public int Subtract(int x, int y) => x - y;

    /// <summary>
    /// Multiplica dos números enteros.
    /// </summary>
    /// <param name="x">Primer número.</param>
    /// <param name="y">Segundo número.</param>
    /// <returns>El producto de los dos números.</returns>
    public int Multiply(int x, int y) => x * y;

    /// <summary>
    /// Divide el primer número entre el segundo.
    /// </summary>
    /// <param name="x">Dividendo.</param>
    /// <param name="y">Divisor.</param>
    /// <returns>El cociente de la división.</returns>
    /// <remarks>No maneja división por cero.</remarks>
    public int Divide(int x, int y) => x / y;
}
