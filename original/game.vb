Public Class Form1
    Dim hs As Double
    Dim clicks As Double = 0
    Dim z As Double = 0


    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        clicks += 1
        lblClicks.Text = "Clicks: " & clicks
        Dim lvl As Double = z / clicks

        If btn1.BackColor = Color.Red Then
            btn1.BackColor = Color.White
        Else : btn1.BackColor = Color.Red
        End If
        If btn2.BackColor = Color.Red Then
            btn2.BackColor = Color.White
        Else : btn2.BackColor = Color.Red
        End If
        If btn4.BackColor = Color.Red Then
            btn4.BackColor = Color.White
        Else : btn4.BackColor = Color.Red
        End If

        If btn1.BackColor = Color.Red And btn2.BackColor = Color.Red And btn3.BackColor = Color.Red And btn4.BackColor = Color.Red And btn5.BackColor = Color.Red And btn6.BackColor = Color.Red And btn7.BackColor = Color.Red And btn8.BackColor = Color.Red And btn9.BackColor = Color.Red Then
            z += 1
            If z = 10 Then
                MessageBox.Show("You win! Your high score is: " & Math.Round((lvl * 100), 2), "You're winner")
                hs = lvl * 100
                z = 0
                clicks = 0
                btn1.BackColor = Color.White
                btn2.BackColor = Color.White
                btn3.BackColor = Color.White
                btn4.BackColor = Color.White
                btn5.BackColor = Color.White
                btn6.BackColor = Color.White
                btn7.BackColor = Color.White
                btn8.BackColor = Color.White
                btn9.BackColor = Color.White
                Me.Text = "Game - High Score: " & Math.Round(hs, 2)
                lblClicks.Text = "Clicks: " & clicks
                lblWin.Text = "Wins: " & z

            ElseIf z = 9 Then
                MessageBox.Show("Congrats! Only " & (10 - z) & " round to go!")
            Else
                MessageBox.Show("Congrats! Only " & (10 - z) & " rounds to go!")
            End If

            If z > 0 Then
                btn1.BackColor = Color.White
                btn2.BackColor = Color.Red
                btn3.BackColor = Color.White
                btn4.BackColor = Color.Red
                btn5.BackColor = Color.White
                btn6.BackColor = Color.White
                btn7.BackColor = Color.White
                btn8.BackColor = Color.Red
                btn9.BackColor = Color.White
                lblWin.Text = "Wins: " & z
            End If
        End If
        txtLvl.Text = Math.Round((lvl * 100), 2)
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        clicks += 1
        lblClicks.Text = "Clicks: " & clicks
        Dim lvl As Double = z / clicks

        If btn1.BackColor = Color.Red Then
            btn1.BackColor = Color.White
        Else : btn1.BackColor = Color.Red
        End If
        If btn2.BackColor = Color.Red Then
            btn2.BackColor = Color.White
        Else : btn2.BackColor = Color.Red
        End If
        If btn3.BackColor = Color.Red Then
            btn3.BackColor = Color.White
        Else : btn3.BackColor = Color.Red
        End If
        If btn5.BackColor = Color.Red Then
            btn5.BackColor = Color.White
        Else : btn5.BackColor = Color.Red
        End If

        If btn1.BackColor = Color.Red And btn2.BackColor = Color.Red And btn3.BackColor = Color.Red And btn4.BackColor = Color.Red And btn5.BackColor = Color.Red And btn6.BackColor = Color.Red And btn7.BackColor = Color.Red And btn8.BackColor = Color.Red And btn9.BackColor = Color.Red Then
            z += 1
            If z = 10 Then
                MessageBox.Show("You win! Your high score is: " & Math.Round((lvl * 100), 2), "You're winner")
                hs = lvl * 100
                z = 0
                clicks = 0
                btn1.BackColor = Color.White
                btn2.BackColor = Color.White
                btn3.BackColor = Color.White
                btn4.BackColor = Color.White
                btn5.BackColor = Color.White
                btn6.BackColor = Color.White
                btn7.BackColor = Color.White
                btn8.BackColor = Color.White
                btn9.BackColor = Color.White
                Me.Text = "Game - High Score: " & Math.Round(hs, 2)
                lblClicks.Text = "Clicks: " & clicks
                lblWin.Text = "Wins: " & z

            ElseIf z = 9 Then
                MessageBox.Show("Congrats! Only " & (10 - z) & " round to go!")
            Else
                MessageBox.Show("Congrats! Only " & (10 - z) & " rounds to go!")
            End If

            If z > 0 Then
                btn1.BackColor = Color.White
                btn2.BackColor = Color.White
                btn3.BackColor = Color.White
                btn4.BackColor = Color.White
                btn5.BackColor = Color.Red
                btn6.BackColor = Color.White
                btn7.BackColor = Color.White
                btn8.BackColor = Color.Red
                btn9.BackColor = Color.White
                lblWin.Text = "Wins: " & z
            End If
        End If
        txtLvl.Text = Math.Round((lvl * 100), 2)
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        clicks += 1
        lblClicks.Text = "Clicks: " & clicks
        Dim lvl As Double = z / clicks

        If btn2.BackColor = Color.Red Then
            btn2.BackColor = Color.White
        Else : btn2.BackColor = Color.Red
        End If
        If btn3.BackColor = Color.Red Then
            btn3.BackColor = Color.White
        Else : btn3.BackColor = Color.Red
        End If
        If btn6.BackColor = Color.Red Then
            btn6.BackColor = Color.White
        Else : btn6.BackColor = Color.Red
        End If

        If btn1.BackColor = Color.Red And btn2.BackColor = Color.Red And btn3.BackColor = Color.Red And btn4.BackColor = Color.Red And btn5.BackColor = Color.Red And btn6.BackColor = Color.Red And btn7.BackColor = Color.Red And btn8.BackColor = Color.Red And btn9.BackColor = Color.Red Then
            z += 1
            If z = 10 Then
                MessageBox.Show("You win! Your high score is: " & Math.Round((lvl * 100), 2), "You're winner")
                hs = lvl * 100
                z = 0
                clicks = 0
                btn1.BackColor = Color.White
                btn2.BackColor = Color.White
                btn3.BackColor = Color.White
                btn4.BackColor = Color.White
                btn5.BackColor = Color.White
                btn6.BackColor = Color.White
                btn7.BackColor = Color.White
                btn8.BackColor = Color.White
                btn9.BackColor = Color.White
                Me.Text = "Game - High Score: " & Math.Round(hs, 2)
                lblClicks.Text = "Clicks: " & clicks
                lblWin.Text = "Wins: " & z

            ElseIf z = 9 Then
                MessageBox.Show("Congrats! Only " & (10 - z) & " round to go!")
            Else
                MessageBox.Show("Congrats! Only " & (10 - z) & " rounds to go!")
            End If

            If z > 0 Then
                btn1.BackColor = Color.Red
                btn2.BackColor = Color.White
                btn3.BackColor = Color.White
                btn4.BackColor = Color.White
                btn5.BackColor = Color.White
                btn6.BackColor = Color.Red
                btn7.BackColor = Color.White
                btn8.BackColor = Color.White
                btn9.BackColor = Color.Red
                lblWin.Text = "Wins: " & z
            End If
        End If
        txtLvl.Text = Math.Round((lvl * 100), 2)
    End Sub

    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        clicks += 1
        lblClicks.Text = "Clicks: " & clicks
        Dim lvl As Double = z / clicks

        If btn1.BackColor = Color.Red Then
            btn1.BackColor = Color.White
        Else : btn1.BackColor = Color.Red
        End If
        If btn4.BackColor = Color.Red Then
            btn4.BackColor = Color.White
        Else : btn4.BackColor = Color.Red
        End If
        If btn7.BackColor = Color.Red Then
            btn7.BackColor = Color.White
        Else : btn7.BackColor = Color.Red
        End If
        If btn5.BackColor = Color.Red Then
            btn5.BackColor = Color.White
        Else : btn5.BackColor = Color.Red
        End If

        If btn1.BackColor = Color.Red And btn2.BackColor = Color.Red And btn3.BackColor = Color.Red And btn4.BackColor = Color.Red And btn5.BackColor = Color.Red And btn6.BackColor = Color.Red And btn7.BackColor = Color.Red And btn8.BackColor = Color.Red And btn9.BackColor = Color.Red Then
            z += 1
            If z = 10 Then
                MessageBox.Show("You win! Your high score is: " & Math.Round((lvl * 100), 2), "You're winner")
                hs = lvl * 100
                z = 0
                clicks = 0
                btn1.BackColor = Color.White
                btn2.BackColor = Color.White
                btn3.BackColor = Color.White
                btn4.BackColor = Color.White
                btn5.BackColor = Color.White
                btn6.BackColor = Color.White
                btn7.BackColor = Color.White
                btn8.BackColor = Color.White
                btn9.BackColor = Color.White
                Me.Text = "Game - High Score: " & Math.Round(hs, 2)
                lblClicks.Text = "Clicks: " & clicks
                lblWin.Text = "Wins: " & z

            ElseIf z = 9 Then
                MessageBox.Show("Congrats! Only " & (10 - z) & " round to go!")
            Else
                MessageBox.Show("Congrats! Only " & (10 - z) & " rounds to go!")
            End If

            If z > 0 Then
                btn1.BackColor = Color.White
                btn2.BackColor = Color.Red
                btn3.BackColor = Color.White
                btn4.BackColor = Color.White
                btn5.BackColor = Color.Red
                btn6.BackColor = Color.White
                btn7.BackColor = Color.Red
                btn8.BackColor = Color.White
                btn9.BackColor = Color.White
                lblWin.Text = "Wins: " & z
            End If
        End If
        txtLvl.Text = Math.Round((lvl * 100), 2)
    End Sub

    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        clicks += 1
        lblClicks.Text = "Clicks: " & clicks
        Dim lvl As Double = z / clicks

        If btn2.BackColor = Color.Red Then
            btn2.BackColor = Color.White
        Else : btn2.BackColor = Color.Red
        End If
        If btn4.BackColor = Color.Red Then
            btn4.BackColor = Color.White
        Else : btn4.BackColor = Color.Red
        End If
        If btn5.BackColor = Color.Red Then
            btn5.BackColor = Color.White
        Else : btn5.BackColor = Color.Red
        End If
        If btn6.BackColor = Color.Red Then
            btn6.BackColor = Color.White
        Else : btn6.BackColor = Color.Red
        End If
        If btn8.BackColor = Color.Red Then
            btn8.BackColor = Color.White
        Else : btn8.BackColor = Color.Red
        End If

        If btn1.BackColor = Color.Red And btn2.BackColor = Color.Red And btn3.BackColor = Color.Red And btn4.BackColor = Color.Red And btn5.BackColor = Color.Red And btn6.BackColor = Color.Red And btn7.BackColor = Color.Red And btn8.BackColor = Color.Red And btn9.BackColor = Color.Red Then
            z += 1
            If z = 10 Then
                MessageBox.Show("You win! Your high score is: " & Math.Round((lvl * 100), 2), "You're winner")
                hs = lvl * 100
                z = 0
                clicks = 0
                btn1.BackColor = Color.White
                btn2.BackColor = Color.White
                btn3.BackColor = Color.White
                btn4.BackColor = Color.White
                btn5.BackColor = Color.White
                btn6.BackColor = Color.White
                btn7.BackColor = Color.White
                btn8.BackColor = Color.White
                btn9.BackColor = Color.White
                Me.Text = "Game - High Score: " & Math.Round(hs, 2)
                lblClicks.Text = "Clicks: " & clicks
                lblWin.Text = "Wins: " & z

            ElseIf z = 9 Then
                MessageBox.Show("Congrats! Only " & (10 - z) & " round to go!")
            Else
                MessageBox.Show("Congrats! Only " & (10 - z) & " rounds to go!")
            End If

            If z > 0 Then
                btn1.BackColor = Color.White
                btn2.BackColor = Color.Red
                btn3.BackColor = Color.White
                btn4.BackColor = Color.White
                btn5.BackColor = Color.White
                btn6.BackColor = Color.White
                btn7.BackColor = Color.Red
                btn8.BackColor = Color.White
                btn9.BackColor = Color.Red
                lblWin.Text = "Wins: " & z
            End If
        End If
        txtLvl.Text = Math.Round((lvl * 100), 2)
    End Sub

    Private Sub btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6.Click
        clicks += 1
        lblClicks.Text = "Clicks: " & clicks
        Dim lvl As Double = z / clicks

        If btn3.BackColor = Color.Red Then
            btn3.BackColor = Color.White
        Else : btn3.BackColor = Color.Red
        End If
        If btn5.BackColor = Color.Red Then
            btn5.BackColor = Color.White
        Else : btn5.BackColor = Color.Red
        End If
        If btn6.BackColor = Color.Red Then
            btn6.BackColor = Color.White
        Else : btn6.BackColor = Color.Red
        End If
        If btn9.BackColor = Color.Red Then
            btn9.BackColor = Color.White
        Else : btn9.BackColor = Color.Red
        End If

        If btn1.BackColor = Color.Red And btn2.BackColor = Color.Red And btn3.BackColor = Color.Red And btn4.BackColor = Color.Red And btn5.BackColor = Color.Red And btn6.BackColor = Color.Red And btn7.BackColor = Color.Red And btn8.BackColor = Color.Red And btn9.BackColor = Color.Red Then
            z += 1
            If z = 10 Then
                MessageBox.Show("You win! Your high score is: " & Math.Round((lvl * 100), 2), "You're winner")
                hs = lvl * 100
                z = 0
                clicks = 0
                btn1.BackColor = Color.White
                btn2.BackColor = Color.White
                btn3.BackColor = Color.White
                btn4.BackColor = Color.White
                btn5.BackColor = Color.White
                btn6.BackColor = Color.White
                btn7.BackColor = Color.White
                btn8.BackColor = Color.White
                btn9.BackColor = Color.White
                Me.Text = "Game - High Score: " & Math.Round(hs, 2)
                lblClicks.Text = "Clicks: " & clicks
                lblWin.Text = "Wins: " & z

            ElseIf z = 9 Then
                MessageBox.Show("Congrats! Only " & (10 - z) & " round to go!")
            Else
                MessageBox.Show("Congrats! Only " & (10 - z) & " rounds to go!")
            End If

            If z > 0 Then
                btn1.BackColor = Color.Red
                btn2.BackColor = Color.White
                btn3.BackColor = Color.White
                btn4.BackColor = Color.White
                btn5.BackColor = Color.White
                btn6.BackColor = Color.Red
                btn7.BackColor = Color.White
                btn8.BackColor = Color.White
                btn9.BackColor = Color.Red
                lblWin.Text = "Wins: " & z
            End If
        End If
        txtLvl.Text = Math.Round((lvl * 100), 2)
    End Sub

    Private Sub btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7.Click
        clicks += 1
        lblClicks.Text = "Clicks: " & clicks
        Dim lvl As Double = z / clicks

        'If btn7.BackColor = Color.Blue Then
        '    MessageBox.Show("♥ Shannon is awesome ♥" & vbNewLine & vbNewLine & "                       Love, Nelson", "Special Easter Egg")
        'End If


        If btn4.BackColor = Color.Red Then
            btn4.BackColor = Color.White
        Else : btn4.BackColor = Color.Red
        End If
        If btn7.BackColor = Color.Red Then
            btn7.BackColor = Color.White
        Else : btn7.BackColor = Color.Red
        End If
        If btn8.BackColor = Color.Red Then
            btn8.BackColor = Color.White
        Else : btn8.BackColor = Color.Red
        End If

        If btn1.BackColor = Color.Red And btn2.BackColor = Color.Red And btn3.BackColor = Color.Red And btn4.BackColor = Color.Red And btn5.BackColor = Color.Red And btn6.BackColor = Color.Red And btn7.BackColor = Color.Red And btn8.BackColor = Color.Red And btn9.BackColor = Color.Red Then
            z += 1
            If z = 10 Then
                MessageBox.Show("You win! Your high score is: " & Math.Round((lvl * 100), 2), "You're winner")
                hs = lvl * 100
                z = 0
                clicks = 0
                btn1.BackColor = Color.White
                btn2.BackColor = Color.White
                btn3.BackColor = Color.White
                btn4.BackColor = Color.White
                btn5.BackColor = Color.White
                btn6.BackColor = Color.White
                btn7.BackColor = Color.White
                btn8.BackColor = Color.White
                btn9.BackColor = Color.White
                Me.Text = "Game - High Score: " & Math.Round(hs, 2)
                lblClicks.Text = "Clicks: " & clicks
                lblWin.Text = "Wins: " & z

            ElseIf z = 9 Then
                MessageBox.Show("Congrats! Only " & (10 - z) & " round to go!")
            Else
                MessageBox.Show("Congrats! Only " & (10 - z) & " rounds to go!")
            End If

            If z > 0 Then
                btn1.BackColor = Color.Red
                btn2.BackColor = Color.White
                btn3.BackColor = Color.Red
                btn4.BackColor = Color.White
                btn5.BackColor = Color.White
                btn6.BackColor = Color.White
                btn7.BackColor = Color.White
                btn8.BackColor = Color.Red
                btn9.BackColor = Color.White
                lblWin.Text = "Wins: " & z
            End If
        End If
        txtLvl.Text = Math.Round((lvl * 100), 2)
    End Sub

    Private Sub btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8.Click
        clicks += 1
        lblClicks.Text = "Clicks: " & clicks
        Dim lvl As Double = z / clicks

        If btn5.BackColor = Color.Red Then
            btn5.BackColor = Color.White
        Else : btn5.BackColor = Color.Red
        End If
        If btn7.BackColor = Color.Red Then
            btn7.BackColor = Color.White
        Else : btn7.BackColor = Color.Red
        End If
        If btn8.BackColor = Color.Red Then
            btn8.BackColor = Color.White
        Else : btn8.BackColor = Color.Red
        End If
        If btn9.BackColor = Color.Red Then
            btn9.BackColor = Color.White
        Else : btn9.BackColor = Color.Red
        End If

        If btn1.BackColor = Color.Red And btn2.BackColor = Color.Red And btn3.BackColor = Color.Red And btn4.BackColor = Color.Red And btn5.BackColor = Color.Red And btn6.BackColor = Color.Red And btn7.BackColor = Color.Red And btn8.BackColor = Color.Red And btn9.BackColor = Color.Red Then
            z += 1
            If z = 10 Then
                MessageBox.Show("You win! Your high score is: " & Math.Round((lvl * 100), 2), "You're winner")
                hs = lvl * 100
                z = 0
                clicks = 0
                btn1.BackColor = Color.White
                btn2.BackColor = Color.White
                btn3.BackColor = Color.White
                btn4.BackColor = Color.White
                btn5.BackColor = Color.White
                btn6.BackColor = Color.White
                btn7.BackColor = Color.White
                btn8.BackColor = Color.White
                btn9.BackColor = Color.White
                Me.Text = "Game - High Score: " & Math.Round(hs, 2)
                lblClicks.Text = "Clicks: " & clicks
                lblWin.Text = "Wins: " & z

            ElseIf z = 9 Then
                MessageBox.Show("Congrats! Only " & (10 - z) & " round to go!")
            Else
                MessageBox.Show("Congrats! Only " & (10 - z) & " rounds to go!")
            End If

            If z > 0 Then
                btn1.BackColor = Color.White
                btn2.BackColor = Color.Red
                btn3.BackColor = Color.Red
                btn4.BackColor = Color.White
                btn5.BackColor = Color.Red
                btn6.BackColor = Color.White
                'btn7.BackColor = Color.Blue
                btn7.BackColor = Color.White
                btn8.BackColor = Color.Red
                btn9.BackColor = Color.White
                lblWin.Text = "Wins: " & z
            End If
        End If
        txtLvl.Text = Math.Round((lvl * 100), 2)
    End Sub

    Private Sub btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn9.Click
        clicks += 1
        lblClicks.Text = "Clicks: " & clicks
        Dim lvl As Double = z / clicks

        If btn6.BackColor = Color.Red Then
            btn6.BackColor = Color.White
        Else : btn6.BackColor = Color.Red
        End If
        If btn8.BackColor = Color.Red Then
            btn8.BackColor = Color.White
        Else : btn8.BackColor = Color.Red
        End If
        If btn9.BackColor = Color.Red Then
            btn9.BackColor = Color.White
        Else : btn9.BackColor = Color.Red
        End If

        If btn1.BackColor = Color.Red And btn2.BackColor = Color.Red And btn3.BackColor = Color.Red And btn4.BackColor = Color.Red And btn5.BackColor = Color.Red And btn6.BackColor = Color.Red And btn7.BackColor = Color.Red And btn8.BackColor = Color.Red And btn9.BackColor = Color.Red Then
            z += 1
            If z = 10 Then
                MessageBox.Show("You win! Your high score is: " & Math.Round((lvl * 100), 2), "You're winner")
                hs = lvl * 100
                z = 0
                clicks = 0
                btn1.BackColor = Color.White
                btn2.BackColor = Color.White
                btn3.BackColor = Color.White
                btn4.BackColor = Color.White
                btn5.BackColor = Color.White
                btn6.BackColor = Color.White
                btn7.BackColor = Color.White
                btn8.BackColor = Color.White
                btn9.BackColor = Color.White
                Me.Text = "Game - High Score: " & Math.Round(hs, 2)
                lblClicks.Text = "Clicks: " & clicks
                lblWin.Text = "Wins: " & z

            ElseIf z = 9 Then
                MessageBox.Show("Congrats! Only " & (10 - z) & " round to go!")
            Else
                MessageBox.Show("Congrats! Only " & (10 - z) & " rounds to go!")
            End If

            If z > 0 Then
                btn1.BackColor = Color.White
                btn2.BackColor = Color.Red
                btn3.BackColor = Color.White
                btn4.BackColor = Color.White
                btn5.BackColor = Color.Red
                btn6.BackColor = Color.White
                btn7.BackColor = Color.Red
                btn8.BackColor = Color.White
                btn9.BackColor = Color.Red
                lblWin.Text = "Wins: " & z
            End If
        End If
        txtLvl.Text = Math.Round((lvl * 100), 2)
    End Sub

End Class
