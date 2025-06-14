Shader "Custom/SampleUnlitShader"{
   Properties{
	   _Color ("Color",Color) = (1,1,1,1)
	   }
	SubShader {
		Tags {
			"RenderPipeline" = "UniversalPipeline"
			"RenderType" = "Opaque"
			}
		

	Pass {
		Name "UnlitPass"
		 
			HLSLPROGRAM
			#pragma vertex Vertex
			#pragma fragment Fragment

			#include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

			float4 _Color;

			struct Attributes {
				float3 positionLS : POSITION;	
			
			};

			struct Varyings{
				float4 positionCS : SV_POSITION;
				};

			Varyings Vertex (Attributes a) {
				Varyings output;
				output.positionCS = TransformObjectToHClip(a.positionLS);
				return output;
				}

			half4 Fragment() : SV_Target {	
					return _Color;
				}

			ENDHLSL
		}
}
}
