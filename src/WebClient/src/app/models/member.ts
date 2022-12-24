import { Photo } from "./photo";

export interface Member {
    username: string;
    firstName: string;
    lastName: string;
    gender: string;
    dateOfBirth: string;
    knownAs: string;
    created: Date;
    lastActive: Date;
    introduction: string;
    lookingFor: string;
    interests: string;
    city: string;
    country: string;
    photos: Photo[];
}


