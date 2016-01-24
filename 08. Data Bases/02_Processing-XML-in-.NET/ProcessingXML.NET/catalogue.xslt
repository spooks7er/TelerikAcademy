<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl">
  <xsl:template match="/">
    <html>
      <body>
        <table border="1">
          <tr bgcolor="#cccccc">
            <th style="text-align:left">Name</th>
            <th style="text-align:left">Artist</th>
            <th style="text-align:left">Year</th>
            <th style="text-align:left">Producer</th>
            <th style="text-align:left">Price</th>
            <th style="text-align:center">Songs</th>
          </tr>
          <xsl:for-each select="albums/album">
            <tr>
              <td>
                <xsl:value-of select="name"/>
              </td>
              <td>
                <xsl:value-of select="artist"/>
              </td>
              <td>
                <xsl:value-of select="year"/>
              </td>
              <td>
                <xsl:value-of select="producer"/>
              </td>
              <td>
                <xsl:value-of select="price"/>
              </td>
              <td>
                <ul>
                  <xsl:for-each select="songs/song">
                    <li>
                      <xsl:value-of select="title"/> - <xsl:value-of select="duration"/>
                    </li>
                  </xsl:for-each>
                </ul>
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>

  </xsl:template>
</xsl:stylesheet>
