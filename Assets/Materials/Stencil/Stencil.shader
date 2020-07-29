Shader "Custom/Stencil"
{
	Properties{}

		SubShader{

			Tags {
				"RenderType" = "Opaque"
			}

			Stencil{
				Ref 0
				Comp NotEqual
				Pass keep
			}

			Pass {
				ZWrite Off
			}
	}
}