Module Module1

    Sub Main()
        Dim Puntos As Integer

        Console.WriteLine("1) Determinar si un número es positivo y par.")
        Console.WriteLine("2) Calcular el cubo de un número entero ingresado por el usuario solo sí, el número es múltiplo de 3 y 5.")
        Console.WriteLine("3) Calcular el cuadrado de un número entero ingresado por el usuario solo sí, el número es múltiplo de 4 y 16.")
        Console.WriteLine("4) Realizar un algoritmo que permita dar una ponderación cualitativa, según una nota cuantitativa:" & vbCrLf &
                          "   - Rango:  0 y 40: Pésimo, Aplazado sin oportunidad" & vbCrLf &
                          "   - Rango:  41 y 45: Deficiente, Aplazado a reparación" & vbCrLf &
                          "   - Rango: 46 y 50: Bajo, Aplazado repetir examen" & vbCrLf &
                          "   - Rango 51 y 60: Regular, No aplazado – Remedial" & vbCrLf &
                          "   - Rango 61 y 70: Bien" & vbCrLf &
                          "   - Rango 71 y 80: Muy Bien" & vbCrLf &
                          "   - Rango 81 y 100: Excelente")
        Console.WriteLine("5) Calcular el pago por galones de gasolina de una estación de servicio, según el tipo de gasolina:" & vbCrLf &
                          "   - Gasolina Premium Extra:  1 litro: 5.000 pesos" & vbCrLf &
                          "   - Gasolina Premium:  1 litro: 3.900 pesos" & vbCrLf &
                          "   - Gasolina Corriente: 1 litro 3.200 pesos" & vbCrLf &
                          "   Se debe mostrar la cantidad de gasolina expresada en galones y litros, el cliente pide en galones.")
        Console.WriteLine("6) Calcular el monto a pagar por el servicio de internet según el nivel del cliente y la cantidad de MB:" & vbCrLf &
                          "   Cada MB tiene un precio de:" & vbCrLf &
                          "   - Nivel 1: 5000 mil pesos" & vbCrLf &
                          "   - Nivel 2: 7000 mil pesos" & vbCrLf &
                          "   - Nivel 3: 9000 mil pesos" & vbCrLf &
                          "   - Nivel 4: 15000 mil pesos" & vbCrLf &
                          "   - Nivel 5: 22000 mil pesos" & vbCrLf &
                          "   - Nivel 6: 30000 mil pesos" & vbCrLf &
                          "   Todos los demás niveles 35000 mil pesos")
        Console.WriteLine("7) Calcular el sueldo a pagar de un trabajador dado que se debe ingresar la cantidad de horas trabajadas y el valor de la hora en pesos.")
        Console.WriteLine("8) Calcular el interés a pagar por un dinero, colocado a generar interés diario. Se debe ingresar la cantidad de dinero, los días que lleva generando interés y el interés. Se debe imprimir el interés y la cantidad de dinero más el interés.")
        Console.WriteLine("9) Leer dos números enteros y determinar ¿cuál de los dos es positivo?")
        Console.WriteLine("10) Realizar un pseudocódigo que sume 3 números e imprima la suma.")
        Console.WriteLine("11) Realizar un pseudocódigo que sume 3 números impares e imprima la suma.")
        Console.WriteLine("12) Dado una compra realizada calcular: el iva e imprimir: la compra sin iva, el iva en pesos y el monto con el iva. Tomar en cuenta que el iva es el 19%.")
        Console.WriteLine()
        Console.WriteLine("seleccione el un punto")
        Puntos = Console.ReadLine

        Select Case Puntos
            Case 1

                Dim nump As Integer
                Console.WriteLine("escriba su numero")
                nump = Console.ReadLine()
                If (nump Mod 2 = 0) And (nump > 0) Then
                    Console.WriteLine(" El numero es positivo y par ")
                Else
                    Console.WriteLine("El numero no es positivo y par")
                End If

            Case 2
                Dim numtc As Integer
                Dim numpot As Integer
                Console.WriteLine("escriba su número")
                numtc = Console.ReadLine()
                If (numtc Mod 3 = 0 And numtc Mod 5 = 0) Then
                    numpot = numtc ^ 3
                    Console.WriteLine("el numero {0} es múltiplo de 3 y 5", numtc)
                    Console.WriteLine("la potencia del numero {0} es {1}", numtc, numpot)
                Else
                    Console.WriteLine("el numero {0} no es múltiplo de 3 y 5", numtc)
                End If

            Case 3
                Dim numtc As Integer
                Dim numpot As Integer
                Console.WriteLine("escriba su número")
                numtc = Console.ReadLine()
                If (numtc Mod 4 = 0 And numtc Mod 16 = 0) Then
                    numpot = numtc ^ 2
                    Console.WriteLine("el numero {0} es múltiplo de 4 y 16", numtc)
                    Console.WriteLine("la potencia del numero {0} es {1}", numtc, numpot)
                Else
                    Console.WriteLine("el numero {0} no es múltiplo de 4 y 16", numtc)
                End If

            Case 4
                Dim nota As Integer
                Console.WriteLine("Ingresa tu nota")
                nota = Console.ReadLine()
                If (nota >= 0) And (nota <= 40) Then
                    Console.WriteLine("Pésimo, Aplazado sin oportunidad")
                ElseIf (nota >= 41) And (nota <= 45) Then
                    Console.WriteLine("Deficiente, Aplazado a reparación")
                ElseIf (nota >= 46) And (nota <= 50) Then
                    Console.WriteLine("Bajo, Aplazado repetir examen")
                ElseIf (nota >= 51) And (nota <= 60) Then
                    Console.WriteLine("Regular, No aplazado – Remedial")
                ElseIf (nota >= 61) And (nota <= 70) Then
                    Console.WriteLine("Bien")
                ElseIf (nota >= 71) And (nota <= 80) Then
                    Console.WriteLine("Muy Bien")
                ElseIf (nota >= 81) And (nota <= 100) Then
                    Console.WriteLine("Excelente")
                Else
                    Console.WriteLine("nota aplica")
                End If

            Case 5
                Dim Gal As Double
                Dim cant As Double
                Dim precio As Double
                Dim GTP As String
                Dim CE As String = "Corriente"
                Dim PE As String = "Premium Extra"
                Dim PM As String = "Premium"
                Console.WriteLine("Que tipo de Gasolina desea")
                Console.WriteLine(PE)
                Console.WriteLine(PM)
                Console.WriteLine(CE)
                GTP = Console.ReadLine()
                Console.WriteLine("Digite la cantidad de galones")
                gal = Console.ReadLine()
                cant = Gal * 3.7854
                If (GTP = PE And Gal > 0) Then
                    precio = cant * 5000
                    Console.WriteLine("Usted pidio {0} galones de gasolina {1} lo que equivale a {2} Litros", Gal, GTP, cant)
                    Console.WriteLine("El precio de la gasolina es de {0}", precio)
                ElseIf (GTP = PM And Gal > 0) Then
                    precio = cant * 3900
                    Console.WriteLine("Usted pidio {0} galones de gasolina {1} lo que equivale a {2} Litros", Gal, PM, cant)
                    Console.WriteLine("El precio de la gasolina es de {0}", precio)
                ElseIf (GTP = CE And Gal > 0) Then
                    precio = cant * 3200
                    Console.WriteLine("Usted pidio {0} galones de gasolina {1} lo que equivale a {2} Litros", Gal, CE, cant)
                    Console.WriteLine("El precio de la gasolina es de {0}", precio)
                Else
                    Console.WriteLine("No se encontro el tipo de gasolina o la cantidad de galones es negativa")
                End If

            Case 6
                Dim Level As Integer
                Dim mbs As Integer
                Dim precio As Double
                Console.WriteLine("escriba el nivel de su servicio a internet")
                Level = Console.ReadLine()
                Console.WriteLine("escriba la cantidad de MB contratadas")
                mbs = Console.ReadLine()
                If (Level = 1 And mbs > 0) Then
                    precio = mbs * 5000
                    Console.WriteLine("El precio a pagar es {0} por el nivel {1} de internet", precio, Level)
                ElseIf (Level = 2 And mbs > 0) Then
                    precio = mbs * 7000
                    Console.WriteLine("El precio a pagar es {0} por el nivel {1} de internet", precio, Level)
                ElseIf (Level = 3 And mbs > 0) Then
                    precio = mbs * 9000
                    Console.WriteLine("El precio a pagar es {0} por el nivel {1} de internet", precio, Level)
                ElseIf (Level = 4 And mbs > 0) Then
                    precio = mbs * 15000
                    Console.WriteLine("El precio a pagar es {0} por el nivel {1} de internet", precio, Level)
                ElseIf (Level = 5 And mbs > 0) Then
                    precio = mbs * 22000
                    Console.WriteLine("El precio a pagar es {0} por el nivel {1} de internet", precio, Level)
                ElseIf (Level = 6 And mbs > 0) Then
                    precio = mbs * 30000
                    Console.WriteLine("El precio a pagar es {0} por el nivel {1} de internet", precio, Level)
                ElseIf (Level >= 6 And mbs > 0) Then
                    precio = mbs * 35000
                    Console.WriteLine("El precio a pagar es {0} por el nivel {1} de internet", precio, Level)
                Else
                    Console.WriteLine("El nivel y la cantidad de MB no puede ser menor de 1")
                End If

            Case 7
                Dim time As Double
                Dim precio As Double
                Dim pagar As Double
                Console.WriteLine("escriba la cantidad de horas trabajadas")
                time = Console.ReadLine()
                Console.WriteLine("escriba el precio de la hora en pesos")
                precio = Console.ReadLine()
                pagar = time * precio
                Console.WriteLine("El precio a pagar es: {0}", pagar)

            Case 8
                Dim money As Double
                Dim cantM As Integer
                Dim intere As Double
                Dim pagos As Double
                Console.WriteLine("escriba la cantidad de dinero")
                money = Console.ReadLine()
                Console.WriteLine("escriba la cantidad de días")
                cantM = Console.ReadLine()
                Console.WriteLine("escriba la tase de interés")
                intere = Console.ReadLine()
                If (money > 0 And cantM > 0 And intere > 0) Then
                    pagos = (money * cantM) * (intere / 100)
                    Console.WriteLine("La cantidad de dinero a generar interes es {0}", money)
                    Console.WriteLine("La cantidad de días son {0} y la tasa de interes es {1}", cantM, intere)
                    Console.WriteLine("El interes a pagar es {0}", pagos)
                End If

            Case 9
                Dim num1 As Double
                Dim num2 As Double
                Console.WriteLine("escriba el primer número")
                num1 = Console.ReadLine()
                Console.WriteLine("escriba el segundo número")
                num2 = Console.ReadLine()
                If (num1 > 0 And num2 > 0) Then
                    Console.WriteLine("Los dos números {0} y {1} son positivos", num1, num2)
                ElseIf (num1 > 0) Then
                    Console.WriteLine("El primer número {0} es positivo", num1)
                ElseIf (num2 > 0) Then
                    Console.WriteLine("El segundo número {0} es positivo", num2)
                Else
                    Console.WriteLine("Los números no son positivos")
                End If

            Case 10
                Dim num1 As Double
                Dim num2 As Double
                Dim num3 As Double
                Dim suma As Double
                Console.WriteLine("Digite el primer número")
                num1 = Console.ReadLine()
                Console.WriteLine("Digite el segundo número")
                num2 = Console.ReadLine()
                Console.WriteLine("Digite el tercer número")
                num3 = Console.ReadLine()
                suma = num1 + num2 + num3
                Console.WriteLine("La suma es {0}", suma)

            Case 11
                Dim numero As Double
                Dim suma As Double
                For i As Integer = 0 To 2 Step 1
                    Console.WriteLine("Digite el numero {0}", (i + 1))
                    numero = Console.ReadLine()
                    If (numero Mod 2 <> 0) Then
                        suma += numero
                    Else
                        Console.WriteLine("El numero no puede ser par")
                        i -= 1
                    End If
                Next
                Console.WriteLine("La suma es: {0}", suma)

            Case 12
                Dim cant1 As Integer
                Dim precio As Double
                Dim stotal As Double
                Dim total As Double
                Const iva As Double = 0.19
                Dim PI
                Console.WriteLine("escriba la cantidad de productos")
                cant1 = Console.ReadLine()
                Console.WriteLine("escriba el valor total de la compra ")
                precio = Console.ReadLine()
                stotal += precio
                PI = stotal * iva
                total = stotal + PI
                Console.WriteLine("la cantidad de productos que lleva son {0}", cant1)
                Console.WriteLine("El subtotal de la compra es {0}", stotal)
                Console.WriteLine("El valor del iva es {0}", PI)
                Console.WriteLine("El total de la compra es {0}", total)

        End Select
    End Sub



End Module
