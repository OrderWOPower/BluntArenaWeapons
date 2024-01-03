<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:output omit-xml-declaration="yes"/>
	<xsl:template match="@*|node()">
		<xsl:copy>
			<xsl:apply-templates select="@*|node()"/>
		</xsl:copy>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='wood_blade_1']/BladeData/Thrust/@damage_type">
		<xsl:attribute name="damage_type">
			<xsl:value-of select="'Blunt'"/>
		</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftingPiece[@id='wood_blade_1']/BladeData/Swing/@damage_type">
		<xsl:attribute name="damage_type">
			<xsl:value-of select="'Blunt'"/>
		</xsl:attribute>
	</xsl:template>
</xsl:stylesheet>