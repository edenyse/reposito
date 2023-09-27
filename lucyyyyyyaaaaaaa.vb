
Imports System

Module Program

    Sub Main(args As String())
        Console.WriteLine("realizado por: Lucia Pe�a Zumba")
        EJER1()
        EJER2()
        EJER3()
        EJER4()

    End Sub

    Sub EJER1()
        Try
            'EJER 1'
            Console.Write("Ingrese la distancia en kil�metros: ")
            Dim distanciaKm As Double = Double.Parse(Console.ReadLine())

            Console.Write("Ingrese el tiempo en horas: ")
            Dim horas As Integer = Integer.Parse(Console.ReadLine())

            Console.Write("Ingrese el tiempo en minutos: ")
            Dim minutos As Integer = Integer.Parse(Console.ReadLine())

            ' Calcular el tiempo total en minutos
            Dim tiempoTotalMinutos As Integer = (horas * 60) + minutos

            ' Calcular la velocidad media en diferentes unidades
            Dim velocidadKmPorHora As Double = distanciaKm / horas
            Dim velocidadKmPorMinuto As Double = distanciaKm / tiempoTotalMinutos
            Dim velocidadKmPorSegundo As Double = distanciaKm / (tiempoTotalMinutos * 60)
            Dim velocidadMPorMinuto As Double = (distanciaKm * 1000) / tiempoTotalMinutos
            Dim velocidadMPorSegundo As Double = (distanciaKm * 1000) / (tiempoTotalMinutos * 60)

            ' Mostrar los resultados en consola
            Console.WriteLine("Velocidad media en Km/h: " & velocidadKmPorHora & " Km/h")
            Console.WriteLine("Velocidad media en Km/min: " & velocidadKmPorMinuto & " Km/min")
            Console.WriteLine("Velocidad media en Km/s: " & velocidadKmPorSegundo & " Km/s")
            Console.WriteLine("Velocidad media en m/min: " & velocidadMPorMinuto & " m/min")
            Console.WriteLine("Velocidad media en m/s: " & velocidadMPorSegundo & " m/s")

            Console.ReadLine() ' Esperar a que el usuario presione Enter antes de cerrar la aplicaci�n

        Catch ex As Exception
        Finally
            Console.WriteLine()
            Console.WriteLine()
            Console.ReadLine()
        End Try

    End Sub

    Sub EJER2()
        Console.Write("coloca el promedio mensual de infracciones (N):")
        Dim InfraccionesMensual As Double = Convert.ToDouble(Console.ReadLine())

        Dim porcentajeMa�ana As Double = 0.2
        Dim porcentajeTarde As Double = 0.35
        Dim porcentajeNoche As Double = 0.45

        Dim infraccionesMa�ana As Double = InfraccionesMensual * porcentajeMa�ana
        Dim infraccionesTarde As Double = InfraccionesMensual * porcentajeTarde
        Dim infraccionesNoche As Double = InfraccionesMensual * porcentajeNoche

        Dim diasEnElMes As Integer = 30

        Dim promedioDiarioMa�ana As Double = infraccionesMa�ana / diasEnElMes
        Dim promedioDiarioTarde As Double = infraccionesTarde / diasEnElMes
        Dim promedioDiarioNoche As Double = infraccionesNoche / diasEnElMes

        Console.Write("resultados:")
        Console.Write($"promedio diario matunino de infracciones" & promedioDiarioMa�ana)
        Console.WriteLine()
        Console.Write($"promedio diario en la tarde de infracciones" & promedioDiarioTarde)
        Console.WriteLine()
        Console.Write($"promedio diario en la noche de infracciones" & promedioDiarioNoche)
        Console.WriteLine()
        Console.WriteLine("presiones enter para salir ")
    End Sub
    Sub EJER3()
        Console.WriteLine()

        Dim NI As Integer
        Dim N2 As Integer

        Console.Write("Inserta el primer n�mero: ")
        NI = Convert.ToInt32(Console.ReadLine())

        Console.Write("Inserta el segundo n�mero: ")
        N2 = Convert.ToInt32(Console.ReadLine())

        If NI Mod N2 = 0 Then
            Console.WriteLine(N2 & " es un divisor de " & NI)
        ElseIf N2 Mod NI = 0 Then
            Console.WriteLine(NI & " es un divisor de " & N2)
        Else
            Console.WriteLine("Ninguno de los n�meros es divisor del otro.")
        End If

        Console.ReadLine()



    End Sub


    Sub EJER4()

        Try

            Dim random As New Random

            Dim num1 As Integer = random.Next()
            Dim num2 As Integer = random.Next()
            Dim num3 As Integer = random.Next()

            Console.WriteLine("Ingrese el primer n�mero:")
            num1 = Convert.ToInt32(Console.ReadLine())

            Console.WriteLine("Ingrese el segundo n�mero:")
            num2 = Convert.ToInt32(Console.ReadLine())

            Console.WriteLine("Ingrese el tercer n�mero:")
            num3 = Convert.ToInt32(Console.ReadLine)

            Dim mayor As Integer = Math.Max(num1, Math.Max(num2, num3))
            Dim menor As Integer = Math.Min(num1, Math.Min(num2, num3))
            Dim medio As Integer = (num1 + num2 + num3 - mayor - menor)

            Console.WriteLine("Random: {0},{1},{2} ", num1, num2, num3)

            Console.WriteLine("El n�mero mayor es: {0}", mayor)
            Console.WriteLine("El n�mero medio es: {0}", medio)
            Console.WriteLine("El n�mero menor es: {0}", menor)

            Console.WriteLine()

            Console.ReadLine()

        Catch ex As Exception
            Console.WriteLine("SE DEBEN INGRESAR SOLO N�MEROS")

        End Try

    End Sub


End Module
