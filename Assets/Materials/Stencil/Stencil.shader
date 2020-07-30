Shader "Custom/Stencil"
{
	Properties{}

		SubShader{

			Tags {
				"RenderType" = "Opaque"
			}

			Pass {
				ZWrite Off
			}
	}
}