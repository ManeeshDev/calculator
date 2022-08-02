Public Class frmCal

    Private lastOperator As String = ""
    Private lastValue As Integer = 0
    Private opeClicked As Boolean = False

    Private Sub removeZero()
        If txtExp.Text = "0" Then
            txtExp.Text = ""
        End If
        If txtAns.Text = "0" Then
            txtAns.Text = ""
        End If
    End Sub

    Private Sub calculate()
        If lastValue <> 0 Then
            Select Case lastOperator
                Case "+"
                    txtAns.Text = lastValue + Convert.ToInt32(txtAns.Text)
                    Exit Select
                Case "-"
                    txtAns.Text = lastValue - Convert.ToInt32(txtAns.Text)
                    Exit Select
                Case "*"
                    txtAns.Text = lastValue * Convert.ToInt32(txtAns.Text)
                    Exit Select
                Case "/"
                    txtAns.Text = lastValue / Convert.ToInt32(txtAns.Text)
                    Exit Select
                Case "%"
                    txtAns.Text = lastValue Mod Convert.ToInt32(txtAns.Text)
                    Exit Select
            End Select
        End If
    End Sub

    Private Sub cmdCls_Click(sender As Object, e As EventArgs) Handles cmdCls.Click
        txtExp.Text = ""
        txtAns.Text = "0"
        lastOperator = ""
        lastValue = 0
        opeClicked = False
    End Sub

    Private Sub cmdBkps_Click(sender As Object, e As EventArgs) Handles cmdBkps.Click
        txtAns.Text = "0"
    End Sub

    Private Sub cmd1_Click(sender As Object, e As EventArgs) Handles cmd1.Click
        removeZero()
        txtExp.Text = txtExp.Text + cmd1.Text
        txtAns.Text = cmd1.Text
        opeClicked = False
    End Sub

    Private Sub cmd2_Click(sender As Object, e As EventArgs) Handles cmd2.Click
        removeZero()
        txtExp.Text = txtExp.Text + cmd2.Text
        txtAns.Text = cmd2.Text
        opeClicked = False
    End Sub

    Private Sub cmd3_Click(sender As Object, e As EventArgs) Handles cmd3.Click
        removeZero()
        txtExp.Text = txtExp.Text + cmd3.Text
        txtAns.Text = cmd3.Text
        opeClicked = False
    End Sub

    Private Sub cmd4_Click(sender As Object, e As EventArgs) Handles cmd4.Click
        removeZero()
        txtExp.Text = txtExp.Text + cmd4.Text
        txtAns.Text = cmd4.Text
        opeClicked = False
    End Sub

    Private Sub cmd5_Click(sender As Object, e As EventArgs) Handles cmd5.Click
        removeZero()
        txtExp.Text = txtExp.Text + cmd5.Text
        txtAns.Text = cmd5.Text
        opeClicked = False
    End Sub

    Private Sub cmd6_Click(sender As Object, e As EventArgs) Handles cmd6.Click
        removeZero()
        txtExp.Text = txtExp.Text + cmd6.Text
        txtAns.Text = cmd6.Text
        opeClicked = False
    End Sub

    Private Sub cmd7_Click(sender As Object, e As EventArgs) Handles cmd7.Click
        removeZero()
        txtExp.Text = txtExp.Text + cmd7.Text
        txtAns.Text = cmd7.Text
        opeClicked = False
    End Sub

    Private Sub cmd8_Click(sender As Object, e As EventArgs) Handles cmd8.Click
        removeZero()
        txtExp.Text = txtExp.Text + cmd8.Text
        txtAns.Text = cmd8.Text
        opeClicked = False
    End Sub

    Private Sub cmd9_Click(sender As Object, e As EventArgs) Handles cmd9.Click
        removeZero()
        txtExp.Text = txtExp.Text + cmd9.Text
        txtAns.Text = cmd9.Text
        opeClicked = False
    End Sub

    Private Sub cmd0_Click(sender As Object, e As EventArgs) Handles cmd0.Click
        removeZero()
        txtExp.Text = txtExp.Text + "0"
        txtAns.Text = cmd0.Text
        opeClicked = False
    End Sub

    Private Sub cmdDot_Click(sender As Object, e As EventArgs) Handles cmdDot.Click
        txtExp.Text = txtExp.Text + "."
        txtAns.Text = txtAns.Text + "."
    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        If Not opeClicked Then
            calculate()
            txtExp.Text = txtExp.Text + " + "
            lastOperator = "+"
            lastValue = Convert.ToInt32(txtAns.Text)
            opeClicked = True
        End If
    End Sub

    Private Sub cmdSub_Click(sender As Object, e As EventArgs) Handles cmdSub.Click
        If Not opeClicked Then
            calculate()
            txtExp.Text = txtExp.Text + " - "
            lastOperator = "-"
            lastValue = Convert.ToInt32(txtAns.Text)
            opeClicked = True
        End If
    End Sub

    Private Sub cmdMul_Click(sender As Object, e As EventArgs) Handles cmdMul.Click
        If Not opeClicked Then
            calculate()
            txtExp.Text = txtExp.Text + " * "
            lastOperator = "*"
            lastValue = Convert.ToInt32(txtAns.Text)
            opeClicked = True
        End If
    End Sub

    Private Sub cmdDiv_Click(sender As Object, e As EventArgs) Handles cmdDiv.Click
        If Not opeClicked Then
            calculate()
            txtExp.Text = txtExp.Text + " ➗ "
            lastOperator = "/"
            lastValue = Convert.ToInt32(txtAns.Text)
            opeClicked = True
        End If
    End Sub

    Private Sub cmdMod_Click(sender As Object, e As EventArgs) Handles cmdMod.Click
        If Not opeClicked Then
            calculate()
            txtExp.Text = txtExp.Text + " % "
            lastOperator = "%"
            lastValue = Convert.ToInt32(txtAns.Text)
            opeClicked = True
        End If
    End Sub

    Private Sub cmdEqu_Click(sender As Object, e As EventArgs) Handles cmdEqu.Click
        calculate()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtDateTime.Text = Format(Now, "hh:mm:ss")
    End Sub


End Class
