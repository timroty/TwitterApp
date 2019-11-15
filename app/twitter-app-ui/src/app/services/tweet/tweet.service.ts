import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { TweetInfo } from 'src/app/models/TweetInfo';

@Injectable({
  providedIn: 'root'
})
export class TweetService {
  public TWEET_ENDPOINT = 'http://localhost:60443/Tweet/getTweets';

  constructor(private httpClient: HttpClient) {}

  getAll(user: string, num: number, userAccess: string, consumerAccess: string): Observable<TweetInfo> {
    return this.httpClient.get<TweetInfo>(this.TWEET_ENDPOINT, {
      params :{
        userName: user,
        numTweets: num.toString(),
        userAccessSecret: userAccess,
        consumerSecret: consumerAccess

    }});
  }

}
