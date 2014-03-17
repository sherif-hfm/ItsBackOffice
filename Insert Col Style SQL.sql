
Declare @SqlStr Xml
Set @SqlStr=
'<ResultGridColumnStyle xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <DataGridColumnStyle>
    <Name>UserID</Name>
    <HeaderText_Ara>UserID</HeaderText_Ara>
    <HeaderText_Eng>UserID</HeaderText_Eng>
    <DataPropertyName_Ara>UserID</DataPropertyName_Ara>
    <DataPropertyName_Eng>UserID</DataPropertyName_Eng>
    <AutoSizeMode>Fill</AutoSizeMode>
    <ColumnType>TextBoxColumn</ColumnType>
  </DataGridColumnStyle>
  <DataGridColumnStyle>
    <Name>UserLogin</Name>
    <HeaderText_Ara>UserLogin</HeaderText_Ara>
    <HeaderText_Eng>UserLogin</HeaderText_Eng>
    <DataPropertyName>UserLogin</DataPropertyName>
    <AutoSizeMode>Fill</AutoSizeMode>
    <ColumnType>TextBoxColumn</ColumnType>
  </DataGridColumnStyle>
  <DataGridColumnStyle>
    <Name>Name_Ara</Name>
    <HeaderText_Ara>Name_Ara</HeaderText_Ara>
    <HeaderText_Eng>Name_Ara</HeaderText_Eng>
    <DataPropertyName_Ara>Name_Ara</DataPropertyName_Ara>
    <DataPropertyName_Eng>Name_Ara</DataPropertyName_Eng>
    <AutoSizeMode>Fill</AutoSizeMode>
    <ColumnType>TextBoxColumn</ColumnType>
  </DataGridColumnStyle>
  <DataGridColumnStyle>
    <Name>Name_Eng</Name>
    <HeaderText_Ara>Name_Eng</HeaderText_Ara>
    <HeaderText_Eng>Name_Eng</HeaderText_Eng>
    <DataPropertyName_Ara>Name_Eng</DataPropertyName_Ara>
    <DataPropertyName_Eng>Name_Eng</DataPropertyName_Eng>
    <AutoSizeMode>Fill</AutoSizeMode>
    <ColumnType>TextBoxColumn</ColumnType>
  </DataGridColumnStyle>
  <DataGridColumnStyle>
    <Name>IsAdmin</Name>
    <HeaderText_Ara>IsAdmin</HeaderText_Ara>
    <HeaderText_Eng>IsAdmin</HeaderText_Eng>
    <DataPropertyName_Ara>IsAdmin</DataPropertyName_Ara>
    <DataPropertyName_Eng>IsAdmin</DataPropertyName_Eng>
    <AutoSizeMode>Fill</AutoSizeMode>
    <ColumnType>CheckBoxColumn</ColumnType>
  </DataGridColumnStyle>
</ResultGridColumnStyle>'

update Srch_SearchMaster set SearchResultStyle_Ara=@SqlStr,SearchResultStyle_Eng=@SqlStr where SearchID=1