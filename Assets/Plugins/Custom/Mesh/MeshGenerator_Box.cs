using UnityEngine;

public static partial class MeshGenerator
{
	private static readonly Vector3[] boxVertices = {
		new Vector3(-0.5f, -0.5f, -0.5f),
		new Vector3( 0.5f, -0.5f, -0.5f),
		new Vector3(-0.5f,  0.5f, -0.5f),
		new Vector3( 0.5f,  0.5f, -0.5f),
		new Vector3(-0.5f, -0.5f,  0.5f),
		new Vector3( 0.5f, -0.5f,  0.5f),
		new Vector3(-0.5f,  0.5f,  0.5f),
		new Vector3( 0.5f,  0.5f,  0.5f),
	};

	private static readonly Vector3[] boxNormals = {
		new Vector3( 0,  0, -1),
		new Vector3( 0,  0,  1),
		new Vector3(-1,  0,  0),
		new Vector3( 1,  0,  0),
		new Vector3( 0, -1,  0),
		new Vector3( 0,  1,  0),
	};
	
	public static Mesh BoxWireframe()
	{
		Vector3[] vertices = boxVertices;
		int[] indices = {
			0, 1, /**/ 1, 3, /**/ 3, 2, /**/ 2, 0, // back
			4, 5, /**/ 5, 7, /**/ 7, 6, /**/ 6, 4, // front
			0, 4, /**/ 1, 5, /**/ 2, 6, /**/ 3, 7, // side
		};

		Mesh mesh = new Mesh {
			vertices = vertices,
		};
		mesh.SetIndices(indices, MeshTopology.Lines, 0);
		return mesh;
	}

	public static Mesh BoxDense()
	{
		Vector3[] vertices = boxVertices;
		int[] indices = {
			2, 1, 0, /**/ 1, 2, 3, // back
			4, 5, 6, /**/ 7, 6, 5, // front
			4, 2, 0, /**/ 2, 4, 6, // left
			1, 3, 5, /**/ 7, 5, 3, // right
			0, 1, 4, /**/ 5, 4, 1, // bottom
			6, 3, 2, /**/ 3, 6, 7, // top
		};

		Mesh mesh = new Mesh {
			vertices = vertices,
		};
		mesh.SetIndices(indices, MeshTopology.Triangles, 0);
		return mesh;
	}

	public static Mesh BoxSparse()
	{
		Vector3[] vertices = {
			boxVertices[0], boxVertices[1], boxVertices[2], boxVertices[3], // back
			boxVertices[4], boxVertices[5], boxVertices[6], boxVertices[7], // front
			boxVertices[0], boxVertices[2], boxVertices[4], boxVertices[6], // left
			boxVertices[1], boxVertices[3], boxVertices[5], boxVertices[7], // right
			boxVertices[0], boxVertices[1], boxVertices[4], boxVertices[5], // bottom
			boxVertices[2], boxVertices[3], boxVertices[6], boxVertices[7], // top
		};
		int[] indices = {
			 2,  1,  0, /**/  1,  2,  3, // back
			 4,  5,  6, /**/  7,  6,  5, // front
			10,  9,  8, /**/  9, 10, 11, // left
			12, 13, 14, /**/ 15, 14, 13, // right
			16, 17, 18, /**/ 19, 18, 17, // bottom
			22, 21, 20, /**/ 21, 22, 23, // top
		};
		Vector3[] normals = {
			boxNormals[0], boxNormals[0], boxNormals[0], boxNormals[0],
			boxNormals[1], boxNormals[1], boxNormals[1], boxNormals[1],
			boxNormals[2], boxNormals[2], boxNormals[2], boxNormals[2],
			boxNormals[3], boxNormals[3], boxNormals[3], boxNormals[3],
			boxNormals[4], boxNormals[4], boxNormals[4], boxNormals[4],
			boxNormals[5], boxNormals[5], boxNormals[5], boxNormals[5],
		};

		Mesh mesh = new Mesh {
			vertices = vertices,
			normals = normals,
		};
		mesh.SetIndices(indices, MeshTopology.Triangles, 0);
		return mesh;
	}
}
