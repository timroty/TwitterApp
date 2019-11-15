import { Component, OnInit } from '@angular/core';
import { TweetObject } from 'src/app/models/TweetObject';
import { TweetService } from 'src/app/services/tweet/tweet.service';
import { TweetInfo } from 'src/app/models/TweetInfo';

@Component({
  selector: 'app-display',
  templateUrl: './display.component.html',
  styleUrls: ['./display.component.scss']
})
export class DisplayComponent implements OnInit {

  tweets: Array<TweetObject>;
  avgFavorites: number;
  avgRetweets: number;
  display: boolean;
  selectedUser = 'opendorse';
  selectedNum = '5';

  constructor(private tweetService: TweetService) { }

  ngOnInit() {}

  getTweets(user: string, num: number, userAccess: string, consumerAccess: string){
    this.display = true;
    this.tweetService.getAll(user,num,userAccess,consumerAccess).subscribe((data : TweetInfo) => {
    this.tweets = data.tweets;
    this.avgFavorites = data.avgFavorites;
    this.avgRetweets = data.avgRetweets;
    });
  }

}
