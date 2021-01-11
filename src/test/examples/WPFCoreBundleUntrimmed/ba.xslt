<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
    xmlns:wix="http://wixtoolset.org/schemas/v4/wxs"
>
    <xsl:output method="xml" indent="yes"/>

    <xsl:template match="@* | node()">
        <xsl:copy>
            <xsl:apply-templates select="@* | node()"/>
        </xsl:copy>
    </xsl:template>

    <xsl:template match="wix:Payload[@SourceFile='SourceDir\WixToolset.Dnc.Host.dll']" >
        <xsl:copy>
            <xsl:attribute name="BAFactoryAssembly" namespace="http://wixtoolset.org/schemas/v4/wxs/bal">yes</xsl:attribute>
            <xsl:apply-templates select="@* | node()"/>
        </xsl:copy>
    </xsl:template>
</xsl:stylesheet>
