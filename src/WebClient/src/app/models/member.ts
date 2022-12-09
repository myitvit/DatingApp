import { Photo } from "./photo";

export interface Member {
    UserName: string;
    FirstName: string;
    LastName: string;
    Gender: string;
    DateOfBirth: string;
    KnownAs: string;
    Created: Date;
    LastActive: Date;
    Introduction: string;
    LookingFor: string;
    Interests: string;
    City: string;
    Country: string;
    Photos: Photo[];
}


