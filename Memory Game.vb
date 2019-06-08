'Snigdha Roy final project VB June 2019'
Public Class Form1
    Dim intrndone As Integer
    Dim intrndtwo As Integer
    Dim intloop As Integer
    Dim intboard(23) As Integer
    Dim intcount As Integer
    Dim oldtag As Integer
    Dim oldpic As PictureBox
    Dim intnomatches As Integer
    Dim intnopoint As Integer = 0
    Dim intmatch As Integer
    Dim lstindexitems As Integer
    Dim picboxsave As PictureBox
    'initializing variables

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'loads all cards to be the same from the back
        picbx1.Image = Image.FromFile("cover.jpg")
        picbx2.Image = Image.FromFile("cover.jpg")
        picbx3.Image = Image.FromFile("cover.jpg")
        picbx4.Image = Image.FromFile("cover.jpg")
        picbx5.Image = Image.FromFile("cover.jpg")
        picbx6.Image = Image.FromFile("cover.jpg")
        picbx7.Image = Image.FromFile("cover.jpg")
        picbx8.Image = Image.FromFile("cover.jpg")
        picbx9.Image = Image.FromFile("cover.jpg")
        picbx10.Image = Image.FromFile("cover.jpg")
        picbx11.Image = Image.FromFile("cover.jpg")
        picbx12.Image = Image.FromFile("cover.jpg")
        picbx13.Image = Image.FromFile("cover.jpg")
        picbx14.Image = Image.FromFile("cover.jpg")
        picbx15.Image = Image.FromFile("cover.jpg")
        picbx16.Image = Image.FromFile("cover.jpg")
        picbx17.Image = Image.FromFile("cover.jpg")
        picbx18.Image = Image.FromFile("cover.jpg")
        picbx19.Image = Image.FromFile("cover.jpg")
        picbx20.Image = Image.FromFile("cover.jpg")
        picbx21.Image = Image.FromFile("cover.jpg")
        picbx22.Image = Image.FromFile("cover.jpg")
        picbx23.Image = Image.FromFile("cover.jpg")
        picbx24.Image = Image.FromFile("cover.jpg")

        'additionally randomizing numbers to eliminate repetition
        'randomizing to set cards to pictures

        Randomize()

        For intloop = 1 To 12
            Do
                intrndone = Int(Rnd() * 24 + 1)

            Loop While (intboard(intrndone) <> 0)
            'if empty, keep random number
            'if not empty, it will keep looping

            Do
                intrndtwo = Int(Rnd() * 24 + 1)

            Loop While ((intrndtwo = intrndone) Or (intboard(intrndtwo - 1) <> 0))
            intboard(intrndone - 1) = intloop
            intboard(intrndtwo - 1) = intloop
        Next intloop
    End Sub

    Private Sub pic_Click(sender As Object, e As EventArgs) Handles picbx1.Click, picbx2.Click,
            picbx3.Click, picbx4.Click, picbx5.Click, picbx6.Click, picbx7.Click, picbx8.Click,
            picbx9.Click, picbx10.Click, picbx11.Click, picbx12.Click, picbx13.Click, picbx14.Click,
            picbx15.Click, picbx16.Click, picbx17.Click, picbx18.Click, picbx19.Click, picbx20.Click,
            picbx21.Click, picbx22.Click, picbx23.Click, picbx24.Click

        Dim pic As PictureBox = sender
        Dim inttag As Integer = pic.Tag

        'determines which pic will match each picture box depending on tag

        If intboard(inttag) = 1 Then
            pic.Image = Image.FromFile("bulbasaur.jpg")
        End If

        If intboard(inttag) = 2 Then
            pic.Image = Image.FromFile("venasaur.png")
        End If

        If intboard(inttag) = 3 Then
            pic.Image = Image.FromFile("squirtle.png")
        End If

        If intboard(inttag) = 4 Then
            pic.Image = Image.FromFile("blastoise.png")
        End If

        If intboard(inttag) = 5 Then
            pic.Image = Image.FromFile("charmander.png")
        End If

        If intboard(inttag) = 6 Then
            pic.Image = Image.FromFile("charizard.png")
        End If

        If intboard(inttag) = 7 Then
            pic.Image = Image.FromFile("froakie.png")
        End If

        If intboard(inttag) = 8 Then
            pic.Image = Image.FromFile("greninja.png")
        End If

        If intboard(inttag) = 9 Then
            pic.Image = Image.FromFile("chesnaught.png")
        End If

        If intboard(inttag) = 10 Then
            pic.Image = Image.FromFile("fennekin.png")
        End If

        If intboard(inttag) = 11 Then
            pic.Image = Image.FromFile("delphox.jpg")
        End If

        If intboard(inttag) = 12 Then
            pic.Image = Image.FromFile("pikachu.jpg")
        End If


    End Sub
End Class
