Module Module1

    Sub Main()
        'Declaramos las variables de tipo entero
        'Arreglo de 6 posiciones
        'Array unidimensional
        Dim Arreglo(6) As Integer
        Dim Suma_positivos, Suma_negativos As Integer
        Console.WriteLine("Ingrese los números")
        'Ciclo for que recorre el la misma cantidad
        'de posicioes que tiene el arreglo
        For i = 1 To 6
            'Mensaje que muestra la posición del ciclo for
            Console.WriteLine("Numero" & i)
            'Método que obtiene los datos ingresados 
            'y lo almacena en el arreglo
            Arreglo(i) = Convert.ToInt32(Console.ReadLine())
            'Condición que evalúa el arreglo
            If Arreglo(i) > 0 Then
                'Operador de asignación += el significado 
                'Suma_Positivos = Suma_Positivos + Arreglo
                Suma_positivos += Arreglo(i)
            Else
                Suma_negativos += Arreglo(i)
            End If
        Next
        Console.WriteLine("La suma de positivos es : " & Suma_positivos)
        Console.WriteLine("La suma de negativos es : " & Suma_negativos)
        Console.ReadLine()
    End Sub

End Module
