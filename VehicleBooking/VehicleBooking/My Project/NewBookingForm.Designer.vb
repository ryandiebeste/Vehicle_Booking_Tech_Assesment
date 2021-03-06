﻿Imports System.IO

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewBookingForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.notes = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.listbox = New System.Windows.Forms.CheckedListBox()
        Me.SuspendLayout()
        '
        'Name
        '
        Me.Name.Location = New System.Drawing.Point(220, 37)
        Me.Name.Name = "Name"
        Me.Name.Size = New System.Drawing.Size(100, 20)
        Me.Name.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Car Model"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Notes (25 Chars max)"
        '
        'notes
        '
        Me.notes.Location = New System.Drawing.Point(220, 145)
        Me.notes.Name = "notes"
        Me.notes.Size = New System.Drawing.Size(100, 20)
        Me.notes.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(111, 224)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 56)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Create Booking"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtp
        '
        Me.dtp.Location = New System.Drawing.Point(220, 119)
        Me.dtp.MaxDate = New Date(2020, 12, 11, 0, 0, 0, 0)
        Me.dtp.MinDate = New Date(2020, 1, 13, 0, 0, 0, 0)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(200, 20)
        Me.dtp.TabIndex = 9
        Me.dtp.Value = New Date(2020, 1, 13, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(143, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(171, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Please fill in form to create booking"
        '
        'listbox
        '
        Me.listbox.FormattingEnabled = True
        Me.listbox.Location = New System.Drawing.Point(220, 68)
        Me.listbox.Name = "listbox"
        Me.listbox.Size = New System.Drawing.Size(200, 49)
        Me.listbox.TabIndex = 11
        '
        'NewBookingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(433, 280)
        Me.Controls.Add(Me.listbox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtp)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.notes)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Name)
        'Me.Name = "NewBookingForm"
        Me.Text = "Client Name:"
        Me.ResumeLayout(False)
        Me.PerformLayout()

        Dim arr As Array
        arr = model()
        For a = 0 To arr.Length - 1
            listbox.Items.Add(arr(a))
        Next

    End Sub
    Public Function model() As Array

        Dim TextFilePath As String = IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "cars.txt")
        Dim r As StreamReader
        r = New StreamReader(TextFilePath)

        Dim textFile As String = r.ReadLine()
        Dim cars As Array
        cars = textFile.Split(",")

        Return cars
    End Function

    Friend WithEvents Name As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents notes As Windows.Forms.TextBox
    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents dtp As Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents BackgroundWorker1 As ComponentModel.BackgroundWorker
    Friend WithEvents listbox As Windows.Forms.CheckedListBox
End Class
