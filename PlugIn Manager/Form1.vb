Imports System.Reflection

Public Class Form1
    Dim dllpath As String = ""
    Private Sub cmd_close_Click(sender As Object, e As EventArgs) Handles cmd_close.Click
        Me.Close()
    End Sub

    Private Sub cmd_open_Click(sender As Object, e As EventArgs) Handles cmd_open.Click
        If fd_open.ShowDialog = DialogResult.OK Then
            dllpath = fd_open.FileName
            txt_path.Text = fd_open.FileName
            CheckDll()
        End If
    End Sub

    Private Sub CarbonFiberButton1_Click(sender As Object, e As EventArgs)
        CheckDll()
    End Sub
    Private Sub CheckDll()
        Try
            Dim loadedDll As Assembly = Assembly.LoadFile(txt_path.Text)

            Dim publicClasses = loadedDll.GetExportedTypes.Where(Function(p) p.IsClass And p.IsPublic)
            For Each classItem In publicClasses
                lv_classes.Items.Add(classItem.ToString)
            Next

        Catch e As Exception
            MessageBox.Show(e.Message)
            Debug.Print(e.Message)
    End Try
    End Sub

    Private Sub lv_classes_DoubleClick(sender As Object, e As EventArgs) Handles lv_classes.DoubleClick
        Dim currentClass As String = lv_classes.Items.Item(lv_classes.SelectedIndex).ToString
        MsgBox(lv_classes.Items.Item(lv_classes.SelectedIndex).ToString)
        lv_methods.Items.Clear()
        Try
            Dim loadedDll As Assembly = Assembly.LoadFile(txt_path.Text)

            Dim types As Type() = loadedDll.GetTypes()
            Dim arrl As ArrayList = New ArrayList()
            For Each cls As Type In types
                Dim methodName As MemberInfo() = cls.GetMethods()
                For Each method As MemberInfo In methodName
                    If method.ReflectedType.IsPublic And method.DeclaringType.FullName = currentClass Then arrl.Add(method.Name.ToString())
                Next
            Next
            For i As Integer = 0 To arrl.Count - 1
                lv_methods.Items.Add(arrl(i).ToString())
            Next
        Catch z As Exception
            MessageBox.Show(z.Message)
            Debug.Print(z.Message)
        End Try

    End Sub

    Private Sub cmd_run_Click(sender As Object, e As EventArgs) Handles cmd_run.Click
        Dim Assembly As Reflection.Assembly = Reflection.Assembly.LoadFile(txt_path.Text)
        Dim classType As Type = Assembly.[GetType](lv_classes.Items.Item(lv_classes.SelectedIndex).ToString)

        Dim obj As Object = Activator.CreateInstance(classType)

        Dim mi As MethodInfo = classType.GetMethod(lv_methods.Items.Item(lv_methods.SelectedIndex).ToString)
        mi.Invoke(obj, Nothing)


    End Sub
End Class
