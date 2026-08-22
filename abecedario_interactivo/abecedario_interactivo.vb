Imports System
Module abecedario_interactivo
    Sub Main(args As String())
        Dim abecedario() As Char = {
            "a"c, "b"c, "c"c, "d"c, "e"c, "f"c, "g"c,
            "h"c, "i"c, "j"c, "k"c, "l"c, "m"c, "n"c,
            "ñ"c, "o"c, "p"c, "q"c, "r"c, "s"c, "t"c,
            "u"c, "v"c, "w"c, "x"c, "y"c, "z"c
        }
        Dim opcion As Integer
        '----------------------------------------------'
        '--|menu_principal_de_abecedario_interactivo|--'
        '----------------------------------------------'
        Do
            Console.WriteLine("menu principal de abecedario interactivo")
            Console.WriteLine("1) Mostrar abecedario")
            Console.WriteLine("2) Consultar letra")
            Console.WriteLine("3) Buscar posicion")
            Console.WriteLine("4) Contar vocales y consonantes")
            Console.WriteLine("5) Invertir abecedario")
            Console.WriteLine("6) Mostrar resumen")
            Console.WriteLine("7) Salir")
            Console.Write("Seleccione una opcion: ")
            If Integer.TryParse(Console.ReadLine(), opcion) = False Then
                Console.WriteLine("Debe ingresar un numero valido.")
                Console.WriteLine()
                Continue Do
            End If
            Select Case opcion
                '------------------------'
                '--|mostrar_abecedario|--'
                '------------------------'
                Case 1
                    Console.WriteLine("abecedario")
                    For i As Integer = 0 To abecedario.Length - 1
                        Console.Write(abecedario(i))
                        If i < abecedario.Length - 1 Then
                            Console.Write(" | ")
                        End If
                    Next
                    Console.WriteLine()
                    Console.WriteLine()
                    Console.WriteLine("abecedario en mayusculas")
                    For i As Integer = 0 To abecedario.Length - 1
                        Console.Write(Char.ToUpper(abecedario(i)))
                        If i < abecedario.Length - 1 Then
                            Console.Write(" | ")
                        End If
                    Next
                    Console.WriteLine()
                    Console.WriteLine()
                '---------------------'
                '--|consultar_letra|--'
                '---------------------'
                Case 2
                    Console.Write("Ingrese una letra: ")
                    Dim texto As String = Console.ReadLine()
                    If String.IsNullOrWhiteSpace(texto) Then
                        Console.WriteLine("Debe ingresar una letra.")
                    Else
                        Dim letra As Char = Char.ToLower(texto(0))
                        Dim posicion As Integer = -1
                        For i As Integer = 0 To abecedario.Length - 1
                            If abecedario(i) = letra Then
                                posicion = i + 1
                                Exit For
                            End If
                        Next
                        If posicion <> -1 Then
                            Dim tipo As String
                            If "aeiou".Contains(letra) Then
                                tipo = "Vocal"
                            Else
                                tipo = "Consonante"
                            End If
                            Console.WriteLine("Letra: " & Char.ToUpper(letra))
                            Console.WriteLine("Posicion: " & posicion)
                            Console.WriteLine("Tipo: " & tipo)
                        Else
                            Console.WriteLine("La letra no pertenece al abecedario.")
                        End If
                    End If
                    Console.WriteLine()
                '---------------------'
                '--|buscar_posicion|--'
                '---------------------'
                Case 3
                    Console.Write("Ingrese una posicion del 1 al 27: ")
                    Dim posicion As Integer
                    If Integer.TryParse(Console.ReadLine(), posicion) Then
                        If posicion >= 1 AndAlso posicion <= abecedario.Length Then
                            Dim letra As Char = abecedario(posicion - 1)
                            Dim tipo As String
                            If "aeiou".Contains(letra) Then
                                tipo = "Vocal"
                            Else
                                tipo = "Consonante"
                            End If
                            Console.WriteLine("Posicion: " & posicion)
                            Console.WriteLine("Letra: " & Char.ToUpper(letra))
                            Console.WriteLine("Tipo: " & tipo)
                        Else
                            Console.WriteLine("La posicion debe estar entre 1 y 27.")
                        End If
                    Else
                        Console.WriteLine("Debe ingresar una posicion valida.")
                    End If
                    Console.WriteLine()
                '--------------------------------'
                '--|contar_vocales_consonantes|--'
                '--------------------------------'
                Case 4
                    Dim vocales As Integer = 0
                    Dim consonantes As Integer = 0
                    For Each letra As Char In abecedario
                        If "aeiou".Contains(letra) Then
                            vocales += 1
                        Else
                            consonantes += 1
                        End If
                    Next
                    Console.WriteLine("conteo del abecedario")
                    Console.WriteLine("Vocales: " & vocales)
                    Console.WriteLine("Consonantes: " & consonantes)
                    Console.WriteLine("Total de letras: " & abecedario.Length)
                    Console.WriteLine()
                '-------------------------'
                '--|invertir_abecedario|--'
                '-------------------------'
                Case 5
                    Console.WriteLine("abecedario invertido")
                    For i As Integer = abecedario.Length - 1 To 0 Step -1
                        Console.Write(Char.ToUpper(abecedario(i)))
                        If i > 0 Then
                            Console.Write(" | ")
                        End If
                    Next
                    Console.WriteLine()
                    Console.WriteLine()
                '---------------------'
                '--|mostrar_resumen|--'
                '---------------------'
                Case 6
                    Dim vocales As Integer = 0
                    Dim consonantes As Integer = 0
                    For Each letra As Char In abecedario
                        If "aeiou".Contains(letra) Then
                            vocales += 1
                        Else
                            consonantes += 1
                        End If
                    Next
                    Console.WriteLine("resumen de abecedario interactivo")
                    Console.WriteLine("Total de letras: " & abecedario.Length)
                    Console.WriteLine("Vocales: " & vocales)
                    Console.WriteLine("Consonantes: " & consonantes)
                    Console.WriteLine("Primera letra: " & Char.ToUpper(abecedario(0)))
                    Console.WriteLine("Ultima letra: " & Char.ToUpper(abecedario(abecedario.Length - 1)))
                    Console.WriteLine()
                '------------------------------'
                '--|salir_del_menu_principal|--'
                '------------------------------'
                Case 7
                    Console.WriteLine("Gracias por utilizar Abecedario Interactivo.")
                Case Else
                    Console.WriteLine("Opcion no valida.")
                    Console.WriteLine()
            End Select
        Loop While opcion <> 7
    End Sub
End Module