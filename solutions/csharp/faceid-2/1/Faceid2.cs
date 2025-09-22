using System;
using System.Collections.Generic;

public class FacialFeatures : IEquatable<FacialFeatures>
{
    public string EyeColor { get; }
    public decimal PhiltrumWidth { get; }

    public FacialFeatures(string eyeColor, decimal philtrumWidth)
    {
        EyeColor = eyeColor;
        PhiltrumWidth = philtrumWidth;
    }

    public bool Equals(FacialFeatures other) => this.GetHashCode() == other.GetHashCode();

    public override bool Equals(object obj) => obj is FacialFeatures ? Equals((FacialFeatures)obj) : false;

    public override string ToString() => $"Eye color: {EyeColor}, Philtrum width: {PhiltrumWidth}";

    public override int GetHashCode() => this.ToString().GetHashCode();

    public static bool operator ==(FacialFeatures left, FacialFeatures right) => left.Equals(right);
    public static bool operator !=(FacialFeatures left, FacialFeatures right) => !left.Equals(right);

}

public class Identity : IEquatable<Identity>
{
    public string Email { get; }
    public FacialFeatures FacialFeatures { get; }

    public Identity(string email, FacialFeatures facialFeatures)
    {
        Email = email;
        FacialFeatures = facialFeatures;
    }

    public bool Equals(Identity other) => this.GetHashCode() == other.GetHashCode();

    public override bool Equals(object obj) => obj is Identity ? Equals((Identity)obj) : false;

    public override int GetHashCode() => this.ToString().GetHashCode();

    public override string ToString() => $"Facial Features: {FacialFeatures}; Email: {this.Email}";

    public static bool operator ==(Identity right, Identity left) => right.Equals(left);
    public static bool operator !=(Identity right, Identity left) => !right.Equals(left);
}

public class Authenticator
{
    public HashSet<Identity> Identities { get; } = new();

    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB) => faceA == faceB;

    public bool IsAdmin(Identity identity) => identity.Email == "admin@exerc.ism" && identity.FacialFeatures.EyeColor == "green" && identity.FacialFeatures.PhiltrumWidth == 0.9m;

    public bool Register(Identity identity) => Identities.Add(identity);

    public bool IsRegistered(Identity identity) => Identities.Contains(identity);

    public static bool AreSameObject(Identity identityA, Identity identityB) => object.ReferenceEquals(identityA, identityB);
}
