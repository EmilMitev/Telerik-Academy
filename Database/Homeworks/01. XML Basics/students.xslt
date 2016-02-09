<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0"
    xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:template match="/">  
  <html>
    <body>
      <h1>My Students</h1>
      <table bgcolor="#E0E0E0" cellspacing="1">
        <tr bgcolor="#EEEEEE">
          <th><b>Name</b></th>
          <th><b>Sex</b></th>
          <th><b>Birht day</b></th>
          <th><b>Phone</b></th>
          <th><b>Email</b></th>
          <th><b>Course</b></th>
          <th><b>Specialty</b></th>
          <th><b>FacultyNumber</b></th>
          <th><b>Exams</b></th>
        </tr>
        <xsl:for-each select="/students/student">
          <tr bgcolor="white">
            <td><xsl:value-of select="name"/></td>
            <td><xsl:value-of select="sex"/></td>
            <td><xsl:value-of select="birthDate"/></td>
            <td><xsl:value-of select="phone"/></td>
            <td><xsl:value-of select="email"/></td>
            <td><xsl:value-of select="course"/></td>
            <td><xsl:value-of select="specialty"/></td>
            <td><xsl:value-of select="facultyNumber"/></td>
            <td>
                <xsl:for-each select="exams/exam">
                  <div>
                    <strong>
                      <xsl:value-of select="examName"/>
                    </strong> /
                    tutor: <xsl:value-of select="tutor"/> /
                    score: <xsl:value-of select="score"/>
                  </div>
                </xsl:for-each>
              </td>
          </tr>
        </xsl:for-each>
      </table>
    </body>
  </html>
</xsl:template>
</xsl:stylesheet>