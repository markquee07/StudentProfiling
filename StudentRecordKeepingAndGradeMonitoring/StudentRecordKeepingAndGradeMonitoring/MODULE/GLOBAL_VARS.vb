Module GLOBAL_VARS
    Public db As New Database()
    Public user_session As New Useraccount
    Public sibling_save As Boolean = False
    Public img As Image
    Public take_photo As Boolean = False
    Public hr_control_update As Boolean = False
    Public hr_id_to_update As Integer

    Public selected_department_value As String
    Public selected_employeetype_value As String
    Public selected_position_value As String

    Public selected_department_id As String
    Public selected_employeetype_id As String
    Public selected_position_id As String

    Public id_for_validation As Integer
End Module
