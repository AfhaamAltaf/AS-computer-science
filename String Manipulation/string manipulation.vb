Module Module1

    Sub Main()

        ' Code manipulation vRC :
        ' + Contains all tasks from 1 - 11
        ' + Language used is visual basic



        Dim cmd As String

       
        Console.WriteLine("List of commands: ")
        Console.WriteLine("Type '1' to check if your code is a pangram or not                                 (Task 1) ")
        Console.WriteLine("Type '2' to replace characters in the string                                       (Task 2) ")
        Console.WriteLine("Type '3' to find at which position a character appears in the string               (Task 3) ")
        Console.WriteLine("Type '4' to find the character that appears the most number of times in the string (Task 4) ")
        Console.WriteLine("Type '5' to find the number of vowels in a string                                  (Task 5) ")
        Console.WriteLine("Type '6' to do the task related to donuts                                          (Task 6) ")
        Console.WriteLine("Type '7' to output the first 2 and last 2 characters of a string                   (Task 7) ")
        Console.WriteLine("Type '8' to change the first and rest of the repeated word to '*'                  (Task 8) ")
        Console.WriteLine("Type '9' to exchange first 2 characters of 2 strings                               (Task 9) ")
        Console.WriteLine("Type '10' to add 'ing' to verbs & 'ly'  to verbs already ending in 'ing'           (Task 10)")
        Console.WriteLine("Type '11' to change 'not bad' to good and anything in between them                 (Task 11)")
        Console.WriteLine(" ")


        Console.Write("what would you like to do : ")
        cmd = Console.ReadLine()
        
        Console.Clear()

        ' FOR TASK 1:

       

        If cmd = "1" Then

            Dim user_input As String
            Dim next_char As Char
            Dim ascii, count As Integer
            Dim Pangram As Boolean

            Console.WriteLine("Check if your code is a pangram or not")
            Console.WriteLine(" ")
            Console.WriteLine(" ")

            Console.Write("Enter a sentence: ")
            user_input = Console.ReadLine()

            If Len(user_input) < 26 Then
                Pangram = False
                Console.WriteLine("Your sentence is not a Pangram")

            Else

                For ascii = 65 To 90
                    Pangram = False


                    For count = 1 To Len(user_input)
                        next_char = UCase(Mid(user_input, count, 1))

                        If Asc(next_char) = ascii Then
                            Pangram = True
                            Exit For
                        End If


                    Next

                    If Pangram = False Then
                        Console.WriteLine("Your sentence is not a pangram")
                        Exit For
                    End If


                Next

                If Pangram = True Then
                    Console.WriteLine("Your sentence is a pangram")
                End If

            End If


        End If




        ' FOR TASK 2:



        If cmd = "2" Then

            Dim user_input, user_input2, alphachange, alphareplace, nextalpha As String
            Dim count As Integer
            user_input2 = ""

            Console.WriteLine("Replace characters in your sentence")
            Console.WriteLine(" ")
            Console.WriteLine(" ")

            Console.Write("Please enter a  sentence: ")
            user_input = LCase(Console.ReadLine())


            Console.Write("Which character do you want to replace: ")
            alphachange = LCase(Console.ReadLine())

            Console.Write("Which character do you want instead: ")
            alphareplace = LCase(Console.ReadLine())

            For count = 1 To Len(user_input)
                nextalpha = Mid(user_input, count, 1)

                If nextalpha = alphachange Then
                    nextalpha = alphareplace
                End If

                user_input2 += nextalpha
            Next

            Console.WriteLine("Final string = " & user_input2)

        End If



        ' FOR TASK 3


        If cmd = "3" Then


            Dim findchar, user_input, user_input2, findspace, specialcounter As String
            Dim count, counter, counting, characterlenth, z, alphabet, bigchar, nums, specialnum As Integer
            characterlenth = 0
            alphabet = 0
            bigchar = 0
            nums = 0
            specialcounter = 0
            user_input = ""
            findchar = ""
            findspace = ""
            


            Console.WriteLine("Find position of a character in your sentence")
            Console.WriteLine(" ")
            Console.WriteLine(" ")

            Console.Write("Please enter a  sentence: ")
            user_input2 = LCase(Console.ReadLine())


            Console.Write("Which character do you want to find: ")
            user_input = LCase(Console.ReadLine())

            For count = 1 To Len(user_input2)
                findchar = Mid(user_input2, count, 1)
                characterlenth += 1
                If findchar = user_input Then
                    Console.WriteLine(user_input & " = " & characterlenth & "th char, ")
                End If
            Next

            For counter = 1 To Len(user_input2)
                findspace = Mid(user_input2, counter, 1)
                If findspace <> " " Then
                    z += 1
                End If
            Next

            For counting = 1 To Len(user_input2)

                specialcounter = Mid(user_input2, counting, 1)

                Select Case specialcounter

                    Case "a" To "z"
                        alphabet += 1
                    Case "1" To "9"
                        nums += 1
                    Case " "

                    Case Else
                        specialnum += 1

                End Select

            Next

            Console.WriteLine(" ")
            Console.WriteLine(" ")
            Console.WriteLine("Lenth of sentence = " & Len(user_input2) & " words (including spaces)")
            Console.WriteLine("Lenth of sentence = " & z & " words (excluding spaces)")
            Console.WriteLine("Number of alphabets in sentence = " & alphabet & " words")
            Console.WriteLine("Number of  special characters in sentence = " & specialnum & " characters ")
            Console.WriteLine("Number of integers in sentence = " & nums & " integers")

        End If

        ' FOR TASK 4


        If cmd = "4" Then

            Dim user_input, numbercounter1, numbercounter2, highestchar, SpPos As String
            Dim count, counter, numofchar, highestnum As Integer

            highestchar = ""
            numofchar = 0
            highestnum = 0
            SpPos = " "


            Console.WriteLine("Find which character comes the most number of times in your sentence")
            Console.WriteLine(" ")
            Console.WriteLine(" ")

            Console.Write("Please enter a  sentence: ")
            user_input = LCase(Console.ReadLine())

            For count = 1 To Len(user_input)
                numbercounter1 = Mid(user_input, count, 1)
                numofchar = 0

                If numbercounter1 = SpPos Then
                    Continue For
                End If

                For counter = 1 To Len(user_input)
                    numbercounter2 = Mid(user_input, counter, 1)

                    If numbercounter2 = numbercounter1 Then
                        numofchar += 1

                        If numofchar > highestnum Then
                            highestnum = numofchar
                            highestchar = numbercounter2
                        End If

                    End If

                Next

            Next


            Console.WriteLine("'" & highestchar & "'" & " comes " & highestnum & " times")
        End If

        ' For Task 5

        If cmd = "5" Then

            Dim count, avowel, evowel, ivowel, ovowel, uvowel As Integer
            Dim nextvowel, user_input As String

            avowel = 0
            evowel = 0
            ivowel = 0
            ovowel = 0
            uvowel = 0


            Console.WriteLine("Find how many vowels appear in sentence")
            Console.WriteLine(" ")
            Console.WriteLine(" ")

            Console.Write("Please enter a  sentence: ")
            user_input = UCase(Console.ReadLine())

            For count = 1 To Len(user_input)
                nextvowel = Mid(user_input, count, 1)

                Select Case nextvowel
                    Case "A" : avowel = avowel + 1
                    Case "E" : evowel = evowel + 1
                    Case "I" : ivowel = ivowel + 1
                    Case "O" : ovowel = ovowel + 1
                    Case "U" : uvowel = uvowel + 1

                End Select


            Next
            Console.WriteLine("A = " & avowel)
            Console.WriteLine("E = " & evowel)
            Console.WriteLine("I = " & ivowel)
            Console.WriteLine("O = " & ovowel)
            Console.WriteLine("U = " & uvowel)

        End If

        ' FOR TASK 6

        If cmd = "6" Then

            Dim inpdonut As Integer


            Console.WriteLine("The task related to donuts")
            Console.WriteLine(" ")
            Console.WriteLine(" ")

            Console.Write("Enter the number of donuts: ")
            inpdonut = Console.ReadLine()

            If inpdonut < 10 Then
                Console.WriteLine("Number of Donuts: " & inpdonut)

            ElseIf inpdonut > 10 Then
                Console.WriteLine("Number of Donuts: Many")

            End If

        End If

        ' FOR TASK 7





        If cmd = "7" Then

            Dim s As String

            Console.WriteLine("Output the first 2 and last 2 characters of a string")
            Console.WriteLine(" ")
            Console.WriteLine(" ")

            Console.Write("Input a word: ")
            s = Console.ReadLine()


            If Len(s) > 1 Then
                Console.Write(Left(s, 2))
                Console.WriteLine(Right(s, 2))

            ElseIf Len(s) < 2 Then
                Console.WriteLine(s)

            End If

        End If

        ' FOR TASK 8




        If cmd = "8" Then

            Dim count, snum As Integer
            Dim s, snext As String
            Dim schar As Char

            snext = ""
            snum = 0


            Console.WriteLine("Convert the repeated characters of the first char of the sentence to '*' ")
            Console.WriteLine(" ")
            Console.WriteLine(" ")

            Console.Write("Enter a sentence: ")
            s = LCase(Console.ReadLine())

            schar = s

            For count = 1 To Len(s)
                snext = Mid(s, count, 1)


                If snext = schar And snum > 0 Then
                    snext = "*"
                End If

                snum += 1

                Console.Write(snext)

            Next

        End If

        ' FOR TASK 9


        If cmd = "9" Then

            Dim a, b, afirst2, bfirst2, anext, bnext As String


            anext = ""


            Console.WriteLine("Swap the first 2 characters of the 2 strings")
            Console.WriteLine(" ")
            Console.WriteLine(" ")

            Console.Write("Enter string A: ")
            a = Console.ReadLine()
            Console.Write("Enter string B: ")
            b = Console.ReadLine()

            afirst2 = Left(a, 2)
            bfirst2 = Left(b, 2)

            anext = Mid(a, 3, Len(a))
            bnext = Mid(b, 3, Len(b))

            Console.WriteLine(bfirst2 & anext & " " & afirst2 & bnext)


        End If


        ' FOR  TASK 1O

        If cmd = "10" Then

            Dim verb As String

            Console.WriteLine("Verbs")
            Console.WriteLine(" ")
            Console.WriteLine(" ")

            Console.Write("Enter verb: ")
            verb = Console.ReadLine()

            If Len(verb) > 2 Then


                If Right(verb, 3) <> "ing" Then
                    Console.WriteLine(verb & "ing")
                ElseIf Right(verb, 3) = "ing" Then
                    Console.WriteLine(verb & "ly")
                End If

            ElseIf Len(verb) < 3 Then
                Console.WriteLine(verb)

            End If


        End If

        ' FOR TASK 11


        If cmd = "11" Then

            Dim count, counter, badreplace As Integer
            Dim userinput As String


            Console.WriteLine("Change 'not bad' to 'good'")
            Console.WriteLine(" ")
            Console.WriteLine(" ")

            Console.Write("Enter sentence: ")
            userinput = Console.ReadLine()

            For count = 1 To Len(userinput)

                For counter = 1 To Len(userinput)

                    If LCase(Mid(userinput, count, 3)) = "not" And LCase(Mid(userinput, counter, 3)) = "bad" Then
                        badreplace = (counter - count)
                        userinput = Left(userinput, (count - 1)) & "good" & Mid(userinput, (counter + 3), (Len(userinput) - (counter + 2)))
                    End If

                Next

            Next
            Console.WriteLine("Your output: " & userinput)
        End If



        Console.ReadKey()
    End Sub

End Module

