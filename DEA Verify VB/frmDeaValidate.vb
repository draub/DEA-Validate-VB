﻿Option Explicit On

''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'Application:  DEA Validate
'Version:  1.0
'Date:  5/12/2019
'
'Application Purpose :   To confirm the validity of DEA identification numbers
'Validation based On the rules As put forward at the following website
'https://en.wikipedia.org/wiki/DEA_number
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

Public Class frmDeaValidate

    Private Sub CmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        Try
            clearResults()
            txtPrescriber.Clear()
            txtDea.Clear()
            txtPrescriber.BackColor = Color.White
            txtDea.BackColor = Color.White
            txtDea.ForeColor = Color.Black
            txtResults.BackColor = Color.FromKnownColor(KnownColor.Control)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub clearResults()
        Try
            txtResults.Clear()
            lblResultsPass.Visible = False
            lblResultsFail.Visible = False
        Catch ex As Exception
        End Try
    End Sub

    Private Sub CmdVerify_Click(sender As Object, e As EventArgs) Handles cmdValidate.Click
        Try

            Dim fieldsPopulated, deaCheckPass, deaGroupValid, deaNumeric As Boolean
            Dim prescriber, dea, deaGroup, txtDeaCheckNotes As String
            Dim deaNum, deaCheckSumA, deaCheckSumB, deaCheckSumTotal As Integer

            'Clear any previous results
            If txtResults.Text <> "" Then
                clearResults()
            End If

            'Remove any spaces from input fields
            prescriber = txtPrescriber.Text
            dea = txtDea.Text

            prescriber = prescriber.Replace(" ", "").ToUpper
            dea = dea.Replace(" ", "").ToUpper

            txtPrescriber.Text = prescriber
            txtDea.Text = dea

            'Verify that required fields are populated
            fieldsPopulated = verifyFieldsPopulated(prescriber, dea)

            If fieldsPopulated = True Then

                'Set as if true.  Any failure of the checks will set to False
                deaCheckPass = True

                'Check 1:  Must be 9 characters long
                If Len(dea) = 9 Then
                    txtDeaCheckNotes = "- Pass: DEA number is 9 characters long" & vbNewLine & vbNewLine
                Else
                    txtDeaCheckNotes = "Fail: Incorrect number of characters" & vbNewLine & vbNewLine
                    deaCheckPass = False
                End If

                'Check 2.A:  First character must be a letter.  
                If IsNumeric(dea(0)) = False Then

                    'Check 2.B:  Letters correspond to certain groups.  Group must be a valid group.
                    deaGroupValid = True

                    Select Case dea(0)
                        Case "A"
                            deaGroup = "A – Deprecated (used by some older entities)"
                        Case "B"
                            deaGroup = "B – Hospital/Clinic"
                        Case "C"
                            deaGroup = "C – Practitioner"
                        Case "D"
                            deaGroup = "D – Teaching Institution"
                        Case "E"
                            deaGroup = "E – Manufacturer"
                        Case "F"
                            deaGroup = "F – Distributor"
                        Case "G"
                            deaGroup = "G – Researcher"
                        Case "H"
                            deaGroup = "H – Analytical Lab"
                        Case "J"
                            deaGroup = "J – Importer"
                        Case "K"
                            deaGroup = "K – Exporter"
                        Case "L"
                            deaGroup = "L – Reverse Distributor"
                        Case "M"
                            deaGroup = "M – Mid Level Practitioner"
                        Case "P", "R", "S", "T", "U"
                            deaGroup = dea(0) & " – Narcotic Treatment Program"
                        Case "R"
                            deaGroup = "R – Narcotic Treatment Program"
                        Case "X"
                            deaGroup = "X – Suboxone/Subutex Prescribing Program"
                        Case Else
                            deaGroup = dea(0) & " - NOT LISTED AS ANY VALID GROUP"
                            deaGroupValid = False
                            deaCheckPass = False
                    End Select

                    If deaGroupValid = True Then
                        txtDeaCheckNotes = txtDeaCheckNotes & "- Pass:  First character is a VALID group" & vbNewLine
                        txtDeaCheckNotes = txtDeaCheckNotes & "        " & deaGroup & vbNewLine & vbNewLine
                    Else
                        txtDeaCheckNotes = txtDeaCheckNotes & "- Fail:  First character is not a VALID group" & vbNewLine
                        txtDeaCheckNotes = txtDeaCheckNotes & "        " & deaGroup & vbNewLine & vbNewLine
                    End If

                Else
                    txtDeaCheckNotes = txtDeaCheckNotes & "- Fail:  First character is not a letter" & vbNewLine & vbNewLine
                    deaCheckPass = False
                End If

                'Check 3:  Second character must be either Prescriber's Last Name Initial, or in some cases it can be the number 9.
                If dea.Length > 1 Then
                    If dea(1) = prescriber(0) Then
                        txtDeaCheckNotes = txtDeaCheckNotes & "- Pass:  Second character matches Prescriber's initial" & vbNewLine & vbNewLine
                    ElseIf Val(dea(1)) = 9 Then
                        txtDeaCheckNotes = txtDeaCheckNotes & "- Pass:  Second character can be 9" & vbNewLine & vbNewLine
                    Else
                        txtDeaCheckNotes = txtDeaCheckNotes & "- Fail:  Second character mismatch" & vbNewLine & vbNewLine
                        deaCheckPass = False
                    End If
                Else
                    txtDeaCheckNotes = txtDeaCheckNotes & "- Fail:  Can not validate second character" & vbNewLine & vbNewLine
                    deaCheckPass = False
                End If

                'Check 4:  Remaining characters must be numbers
                deaNumeric = True
                If dea.Length >= 9 Then
                    For deaNum = 3 To 8
                        If IsNumeric(dea(deaNum)) = False Then
                            deaNumeric = False
                        End If
                    Next

                    If deaNumeric = True Then
                        txtDeaCheckNotes = txtDeaCheckNotes & "- Pass:  Remaining characters are numeric" & vbNewLine & vbNewLine
                    Else
                        txtDeaCheckNotes = txtDeaCheckNotes & "- Fail:  Remaining characers are not numeric" & vbNewLine & vbNewLine
                        deaCheckPass = False
                        deaNumeric = False
                    End If
                Else
                    txtDeaCheckNotes = txtDeaCheckNotes & "- Fail:  Can not validate remaining characters" & vbNewLine & vbNewLine
                    deaCheckPass = False
                    deaNumeric = False
                End If

                'Check 5:  Last character is the verfication check:  It needs to match the last digit of the following formula:
                '(Characters 3 + 5 + 7) + ((Characters 4 + 6 + 8) * 2)
                If deaNumeric = True Then
                    deaCheckSumA = Val(dea(2)) + Val(dea(4)) + Val(dea(6))
                    deaCheckSumB = (Val(dea(3)) + Val(dea(5)) + Val(dea(7))) * 2
                    deaCheckSumTotal = deaCheckSumA + deaCheckSumB

                    If Microsoft.VisualBasic.Right(dea, 1) = Microsoft.VisualBasic.Right(deaCheckSumTotal, 1) Then
                        txtDeaCheckNotes = txtDeaCheckNotes & "- Pass:  Checksum calculation passes"
                    Else
                        txtDeaCheckNotes = txtDeaCheckNotes & "- Fail:  Checksum calculation fails"
                        deaCheckPass = False
                    End If

                Else
                    txtDeaCheckNotes = txtDeaCheckNotes & "- Fail:  Unable to calculate checksum"
                    deaCheckPass = False
                End If

                If deaCheckPass = True Then
                    lblResultsPass.Visible = True
                    txtDea.BackColor = Color.Honeydew
                    txtDea.ForeColor = Color.Green
                    txtResults.BackColor = Color.Honeydew
                Else
                    lblResultsFail.Visible = True
                    txtDea.BackColor = Color.MistyRose
                    txtDea.ForeColor = Color.Red
                    txtResults.BackColor = Color.MistyRose
                End If

                txtResults.Text = txtDeaCheckNotes
            End If

        Catch ex As Exception
        End Try
    End Sub

    Function verifyFieldsPopulated(prescriber As String, dea As String) As Boolean
        'Try

        Dim msgText, msgTitle As String

            If prescriber <> "" And dea <> "" Then
                txtPrescriber.BackColor = Color.White
                txtDea.BackColor = Color.White
                Return True
            Else
                msgText = "Please input the following required fields:" & vbNewLine
                msgTitle = "Missing fields"

                If prescriber = "" Then
                    msgText = msgText & "- Prescriber Last Name" & vbNewLine
                    txtPrescriber.BackColor = Color.Yellow
                Else
                    txtPrescriber.BackColor = Color.White
                End If

                If dea = "" Then
                    msgText = msgText & "- DEA Number"
                    txtDea.BackColor = Color.Yellow
                Else
                    txtDea.BackColor = Color.White
                End If

                'Set focus to first missing text field.
                If prescriber = "" Then
                    txtPrescriber.Select()
                Else
                    txtDea.Select()
                End If

                MessageBox.Show(msgText, msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If

        'Catch ex As Exception
        'End Try
    End Function

    Private Sub ChkDetails_CheckedChanged(sender As Object, e As EventArgs) Handles chkDetails.CheckedChanged
        Try
            If chkDetails.Checked Then
                Me.Width = 610

            Else
                Me.Width = 245
            End If

        Catch ex As Exception
        End Try
    End Sub
End Class
