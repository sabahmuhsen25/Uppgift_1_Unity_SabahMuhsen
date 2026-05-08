using System.IO.Hashing;
using System.Runtime.InteropServices.WindowsRuntime;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
public class Distance : MonoBehaviour
{
    void Start()
    {
        // distance
        float dist = GetDistanceBetweenTwoPoints(0, 5, 10, 15);
        print(dist);
        //Vektor + Vektor
        Vector3 sum = GetSumman(1, 2, 3, 4, 5, 6);
        print(sum);
        //Vektor - Vektor
        Vector3 res = GetResten(1, 2, 3, 4, 5, 6);
        print("Resten :" + res);
        //Vektor * Vektor
        Vector3 pro = GetResten(1, 2, 3, 4, 5, 6);
        print("Product :" + pro);
        // Victor / Vector
        Vector3 divRest = GetRestAvDivision(1, 2, 3, 4, 5, 6);
        print("DivisionRest :" + divRest);
        //Vektor * float
        Vector3 prod = MultiVectorFloat(1, 2, 3, 4);
        print("Product av mult :" + prod);
        //Vektor / float
        Vector3 rest = MultiVectorFloat(1, 2, 3, 4);
        print(" Rest : " + rest);
        //Vektor += Vektor
        Vector3 newV = AddVectorToVector(1, 2, 3, 4, 5, 6);
        print("Addition av dom: " + newV);
        // Vektor -= Vektor
        Vector3 resten = GetRest(1, 2, 3, 4, 5, 6);
        print("Product :" + resten);
        //Vektor *= Vektor
        Vector3 product = GetProducts(1, 2, 3, 4, 5, 6);
        print("Products :" + product);
        //Vektor /= Vektor
        Vector3 divRests = GetRestAvDivisions(1, 2, 3, 4, 5, 6);
        print("DivisionRest :" + divRests);
        // Dot
        float tot = GetDot(1, 0, 0, -1, 0, 0);
        //Vector3 tot =  GetDot(1, 2, 3, 4, 5, 6);
        print("dot :" + tot);
        //Sqr
        float lengthSqr = GetLengthSqr(1, 2, 3);
        print(lengthSqr);
        // Normalizesed
       // float length = GetLengthSqr(1, 2, 3);
       // print( length);
       // Vector3 ret = GetLengthSqr(1, 2, 3);
       // print(ret);

    }

  
    // Get distance between 2 points
    float GetDistanceBetweenTwoPoints(float x1, float y1, float x2, float y2)
    {
        float dx = x2 - x1;
        float dy = y2 - y1;
        float distSqwuard = dx * dx + dy * dy;
        float dist = Mathf.Sqrt(distSqwuard);
        return dist;
    }
    // Vector3 + Vector3
    Vector3 GetSumman(float x1, float y1, float z1, float x2, float y2, float z2)
    {
        float posX = x1 + x2;
        float posY = y1 + y2;
        float posZ = z1 + z2;
        Vector3 sum = new Vector3(posX, posY, posZ);
        return sum;
    }
    // subtaction
    Vector3 GetResten(float x1, float y1, float z1, float x2, float y2, float z2)
    {
        float restX = x2 - x1;
        float restY = y2 - y1;
        float restZ = z2 - z1;
        Vector3 res = new Vector3(restX, restY, restZ);
        return res;
    }
    //Vektor * Vektor
    Vector3 GetProduct(float x1, float y1, float z1, float x2, float y2, float z2)
    {
        float prodx = x1 * x2;
        float prody = y1 * y2;
        float prodz = z1 * z2;
        Vector3 pro = new Vector3(prodx, prody, prodz);
        return pro;
    }
    //Vektor / Vektor
    Vector3 GetRestAvDivision(float x1, float y1, float z1, float x2, float y2, float z2)
    {
        float divRestx = x2 / x1;
        float divResty = y2 / y1;
        float divRestz = z2 / z1;
        Vector3 divRest = new Vector3(divRestx, divResty, divRestz);

        return divRest;
    }
    //Vektor * float
    Vector3 MultiVectorFloat(float x1, float y1, float z1, float a)
    {
        float productx = x1 / a;
        float producty = y1 / a;
        float productz = z1 / a;
        Vector3 prod = new Vector3(productx, producty, productz);
        return prod;
    }
    //Vektor / float
    Vector3 vectorDivFloat(float x1, float y1, float z1, float a)
    {
        float restx = x1 / a;
        float resty = y1 / a;
        float restz = z1 / a;
        Vector3 rest = new Vector3(restx, resty, restz);
        return rest;
    }
    //Vektor += Vektor
    Vector3 AddVectorToVector(float x1, float y1, float z1, float x2, float y2, float z2)
    {
        float newVx = x1 + x2;
        float newVy = y1 + y2;
        float newVz = z1 + z2;
        Vector3 newV = new Vector3(newVx, newVy, newVz);
        return newV;
    }
    //Vektor -= Vektor
    Vector3 GetRest(float x1, float y1, float z1, float x2, float y2, float z2)
    {
        float restX = x2 - x1;
        float restY = y2 - y1;
        float restZ = z2 - z1;
        Vector3 resten = new Vector3(restX, restY, restZ);
        return resten;
    }
    //Vektor *= Vektor
    Vector3 GetProducts(float x1, float y1, float z1, float x2, float y2, float z2)
    {
        float prodx = x1 * x2;
        float prody = y1 * y2;
        float prodz = z1 * z2;
        Vector3 product = new Vector3(prodx, prody, prodz);
        return product;
    }
    //Vektor /= Vektor
    Vector3 GetRestAvDivisions(float x1, float y1, float z1, float x2, float y2, float z2)
    {
        float divRestx = x2 / x1;
        float divResty = y2 / y1;
        float divRestz = z2 / z1;
        Vector3 divRests = new Vector3(divRestx, divResty, divRestz);

        return divRests;
    }
    //Dot()
    float GetDot(float x1, float y1, float z1, float x2, float y2, float z2)
    {
        float prodX = x1 * x2;
        float prodY = y1 * y2;
        float prodZ = z1 * z2;
        float tot = prodX + prodY + prodZ;
        return tot;
    }
    // Sqr
    float GetLengthSqr(float x, float y, float z) 
    {
        float lengthSqr;
        lengthSqr = x*x + y*y + z*z;
	    return lengthSqr;
    }
    //Get normalised
    /*Vector3 GetNormalized(float x,float y ,float z) 
    {

         Vector3 ret;
         float length = Length( x*x + y*y + z*z);
         ret.X = X / length;
	     ret.Y = Y / length;
	     ret.Z = Z / length;
	     return ret;
    }
    */
}
/*
 #include "Vector3.h"

Vector3::Vector3()
{
	X = 0;
	Y = 0;
	Z = 0;
}

Vector3::Vector3(float aX, float aY, float aZ)
{
	X = aX;
	Y = aY;
	Z = aZ;
}

Vector3 Vector3::operator+(const Vector3& other) const
{	
	Vector3 ret;
	ret.X = X + other.X;
	ret.Y = Y + other.Y;
	ret.Z = Z + other.Z;
	return ret;
}

Vector3 Vector3::operator-(const Vector3& other) const
{
	Vector3 ret;
	ret.X = X - other.X;
	ret.Y = Y - other.Y;
	ret.Z = Z - other.Z;
	return ret;
}


Vector3 Vector3::operator+=(const Vector3& other)
{
	X += other.X;
	Y += other.Y;
	Z += other.Z;
	return *this;
}

std::string Vector3::PrintVector()
{
	std::string ret = "(" + std::to_string(X) + ", " + std::to_string(Y) + ", " + std::to_string(Z) + ")";
	return ret;
}

float Vector3::Length() const
{
	float length;
	length = std::pow(X, 2) + std::pow(Y, 2) + std::pow(Z, 2);
	length = std::sqrt(length);
	return length;
}

float Vector3::LengthSqr() const
{
	float lengthSqr;
	lengthSqr = std::pow(X, 2) + std::pow(Y, 2) + std::pow(Z, 2);
	return lengthSqr;
}

Vector3 Vector3::GetNormalized() const
{
	Vector3 ret;
	float length = Length();
	ret.X = X / length;
	ret.Y = Y / length;
	ret.Z = Z / length;
	return ret;
}

Vector3 Vector3::Normalize()
{
	float length = Length();
	X /= length;
	Y /= length;
	Z /= length;
	return *this;
}

float Vector3::Dot(const Vector3& other) const
{
	return X * other.X + Y * other.Y + Z * other.Z;
}
----------------
 Vektor klassen ska ha dessa fungerande funktioner:
Vektor + Vektor
Vektor - Vektor
Vektor * Vektor
Vektor / Vektor
Vektor * float
Vektor / float
Vektor1 += Vektor2 == Vektor1 = Vektor1 + Vektor2
Vektor -= Vektor
Vektor *= Vektor
Vektor /= Vektor
Vektor *= float
Vektor /= float
Length()
LengthSqr()
Normalize()
Dot()
Cross()

 */
